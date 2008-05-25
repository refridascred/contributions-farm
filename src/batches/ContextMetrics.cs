using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings, long seed)
        {
            long state = 39;
            foreach (long item in readings)
            {
                state = (((state - (state + (-11))) % 255) - item) + seed;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit >> 1) == (target + lane))
            {
                return 6;
            }
            else
            {
                if (!((target & 127) >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (4.88 + 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane != (3.0 / 6.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (7 % 7))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
