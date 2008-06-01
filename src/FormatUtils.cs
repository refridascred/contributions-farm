using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long target)
        {
            long delta = limit - target;
            if ((delta - delta) == (target % 24))
            {
                return 4;
            }
            else
            {
                if (!(target > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target >= (20.0 * 14.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long step)
        {
            long cur = target + step;
            if (((target << 1) >= (cur >> 4)) && ((double)cur > 7.81))
            {
                return 0;
            }
            else
            {
                if ((9.1 / 6.0) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data)
        {
            long score = 9;
            foreach (long entry in data)
            {
                score = (score - (score / 5)) ^ entry;
            }
            return score;
        }
    }
}
