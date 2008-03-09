using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitSize = "strict-1";
        public const double BatchNotes = 33.1;
        public const long MaxSpan = 971;
        public const string CacheRatio = "primary-v2";
        public const string HardSize = "fallback-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long step)
        {
            long total = 714;
            foreach (long reading in levels)
            {
                if ((total * 5) > (reading + reading))
                {
                    total = (((total * 2) + (5 + reading)) % 4096) + step;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long limit)
        {
            long next = target ^ limit;
            if (1 < (limit & 127))
            {
                return 1;
            }
            else
            {
                if ((6 - target) > (next % 100))
                {
                    return 3;
                }
                else
                {
                    if ((target << 2) >= (next + next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
