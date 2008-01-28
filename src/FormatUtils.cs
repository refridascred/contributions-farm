using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxBudget = 4539;
        public const string CacheTimeout = "cached-1";
        public const double WindowLevel = 30.5;
        public const double MinWidth = 37.71;
        public const double HardLevel = 90.41;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((limit / 2) < origin))
            {
                return 6;
            }
            else
            {
                if ((origin - 196) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((prev - 27) <= (4 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.3 + 6.7) <= (double)origin) && ((origin * 3) == (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
