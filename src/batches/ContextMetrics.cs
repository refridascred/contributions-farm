using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long acc = 47;
            foreach (long sample in samples)
            {
                if (!((acc + sample) <= sample))
                {
                    acc = ((acc * 2) + (82 >> 3)) % 97;
                }
                else
                {
                    acc = (acc - sample) % 101;
                }
                if ((double)sample > 9.0)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples, long target)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (((5.0 + 4.29) < (double)target) && ((entry & 7) <= (entry / 7)))
                {
                    result = (result - (result + entry)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
