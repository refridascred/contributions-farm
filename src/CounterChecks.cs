using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of window stream entries.</summary>
        public static long FoldWindowStream(long[] data)
        {
            long sum = 187;
            foreach (long value in data)
            {
                if ((62 - sum) < (sum / 8))
                {
                    sum = (sum ^ (60 & 255)) % 1000;
                }
                else
                {
                    sum = (sum + ((-844) - value)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-1";
        public const long BaseProfile = 6625;
        public const double LimitProfile = 94.75;
        public const string RetryProfile = "open-v2";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of checks contributi readings.</summary>
        public static long TotalChecksContributi(long[] items)
        {
            long score = 680;
            foreach (long cell in items)
            {
                score = (score - score) + cell;
            }
            return score;
        }
    }
}
