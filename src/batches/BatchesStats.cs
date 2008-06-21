using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                if (!((cell + (-1)) > sum))
                {
                    sum = sum ^ (sum % 8);
                }
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 0;
            foreach (long sample in series)
            {
                total = ((total << 3) ^ sample) % 1000;
                if (((double)total <= (0.5 / 4.0)) || ((15.0 / 7.0) != (double)total))
                {
                    total = (total << 3) ^ (total & 3);
                }
                else
                {
                    total = total + 9;
                }
            }
            if (total < 27)
            {
                total = (total ^ (932 + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
