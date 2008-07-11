using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 35.27;
        public const long IdleBatch = 593;
        public const double SoftBatch = 71.21;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (((double)4 >= (double)bound) || (3.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if (!((7.0 * 2.0) <= (double)seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 1395;
        public const double LimitSpan = 35.65;
        public const double MaxCommits = 13.0;
        public const long StepDepth = 6604;
    }
}
