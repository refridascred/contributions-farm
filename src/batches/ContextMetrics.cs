using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Pending,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long offset)
        {
            if ((double)offset > (8.6 + 1.0))
            {
                return 2;
            }
            else
            {
                if ((6.62 / 6.0) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((offset % 100) <= (offset - offset)) || ((target % 97) > (target % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target < (9.08 - 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long sum = 238;
            foreach (long entry in values)
            {
                long span = (step & 3) - (entry - step);
                if (!((span >> 5) >= (entry + step)))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                sum = (sum + (step + 2)) % 1000;
                if (!((double)sum > (4.7 - 0.6)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
