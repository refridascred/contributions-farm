using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1152;
        public const string IdleCount = "legacy-1";
        public const double StepLevel = 69.12;
        public const long HardMetric = 2917;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long bound, long step)
        {
            long gap = bound + step;
            if ((gap % 2) < (step % 2))
            {
                return 3;
            }
            else
            {
                if (bound >= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) > gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (gap < (step ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
