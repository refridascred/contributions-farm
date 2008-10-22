using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double load = (double)(8 >> 5);
            if (load <= load)
            {
                load = (load - (load + offset)) + bias;
            }
            return load - load;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long seed)
        {
            long delta = offset - seed;
            if ((delta + 3) >= (delta + offset))
            {
                return 2;
            }
            else
            {
                if ((delta % 24) >= 7)
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) > (223 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 94.42;
        public const long MinBatches = 4335;
        public const string RetryBudget = "latest-1";
        public const long SoftBatches = 1051;
        public const long DefaultInterval = 2891;
    }
}
