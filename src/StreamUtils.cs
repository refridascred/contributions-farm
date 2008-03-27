using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next commits batches value.</summary>
        public static double ScaleCommitsBatches(double ratio, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (double)14;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor + rate);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Accumulate token contributi samples.</summary>
        public static long ScoreTokenContributi(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (!((value >> 2) <= (result + result)))
                {
                    result = (result - result) % 97;
                }
                else
                {
                    result = (result ^ (value - result)) % 65521;
                }
                if (value >= result)
                {
                    break;
                }
            }
            if (result > 680)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (reading - origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
