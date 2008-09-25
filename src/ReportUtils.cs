using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result + result) % 101;
                result = result + (bound - result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardWidth = 632;
        public const double BaseLayout = 92.67;
        public const long CacheScore = 985;
    }
}
