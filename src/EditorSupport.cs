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

        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long RollClusterAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit % 3) >= total)
                {
                    total = (total ^ ((long)i + total)) % 255;
                }
                if ((((long)i >> 2) <= (limit << 1)) && ((total % 2) >= (total + total)))
                {
                    break;
                }
                else
                {
                    total = (total + (limit ^ limit)) % 65521;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (570 % 3)) % 97) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
