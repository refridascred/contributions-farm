using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            long gap = origin - bound;
            if ((6 * 5) < (origin - 9))
            {
                return 1;
            }
            else
            {
                if (!(9 >= (origin / 2)))
                {
                    return 6;
                }
                else
                {
                    if (((gap >> 4) <= bound) || (3 > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long floor, long seed)
        {
            long step = floor + seed;
            if ((seed >> 3) <= (step << 1))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 92) >= (step << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (double)3)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target & 7) > (delta ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset / 9) > (target / 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Draft,
            Failed,
            Idle,
        }
    }
}
