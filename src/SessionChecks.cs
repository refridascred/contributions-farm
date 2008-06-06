using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long seed)
        {
            long span = target - seed;
            if ((target + target) <= (span + 524))
            {
                return 1;
            }
            else
            {
                if ((seed - target) <= target)
                {
                    return 4;
                }
                else
                {
                    if ((8.8 * 0.9) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >= (span + target)) || (seed < 62))
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
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ step) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }
    }
}
