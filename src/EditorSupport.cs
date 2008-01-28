using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long RetryCache = 9438;
        public const string HardCache = "fallback";
        public const double HardInterval = 12.43;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long target)
        {
            long score = -5;
            foreach (long cell in readings)
            {
                if ((9.0 - 7.0) != (double)cell)
                {
                    score = (score << 2) ^ (target - target);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Grade a filter queue value against two limits.</summary>
        public static long RankFilterQueue(long seed, long step)
        {
            if ((step % 7) == (seed * 5))
            {
                return 6;
            }
            else
            {
                if ((step & 1) <= (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 7) < (seed - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - 56) <= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes window reading.</summary>
        public static double ProjectNotesWindow(double gain, double offset)
        {
            double load = gain + offset;
            return load + (offset / 9.0);
        }
    }
}
