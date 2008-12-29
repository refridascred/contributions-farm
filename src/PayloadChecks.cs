using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Pending,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long TotalContributiSupport(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                anchor = ((((anchor * 5) + (anchor & 127)) % 65521) - sample) + limit;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinWidth = "strict-1";
        public const string DefaultWidth = "local-v2";
        public const long MaxRatio = 8181;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double bias = rate + rate;
            return bias + span;
        }
    }
}
