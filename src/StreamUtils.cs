using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            New,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TotalSupportChannel(long[] values, long origin)
        {
            long result = 720;
            foreach (long entry in values)
            {
                result = (result + (origin - origin)) % 4096;
                result = (result + (origin + origin)) % 65521;
                if (((30 * 2) < result) || ((double)entry < 12.0))
                {
                    break;
                }
            }
            if (result < 79)
            {
                result = result ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double load = offset * 8.88;
            if (load > (double)809)
            {
                load = (load - offset) - rate;
            }
            return load + load;
        }

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool ValidateClusterEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long floor)
        {
            long mix = 479;
            foreach (long value in values)
            {
                if ((mix + mix) <= (floor + floor))
                {
                    mix = (mix * 2) + (mix / 5);
                }
                else
                {
                    mix = ((mix * 2) + value) % 97;
                }
            }
            return mix;
        }
    }
}
