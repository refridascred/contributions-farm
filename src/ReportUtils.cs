using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long step)
        {
            if ((step + 85) > (step + offset))
            {
                return 7;
            }
            else
            {
                if (((11.0 * 14.0) <= (double)step) || ((step & 7) <= (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (offset <= 9)
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

        /// <summary>Accumulate contributi metrics samples.</summary>
        public static long ScoreContributiMetrics(long[] items, long target)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((long)items.Length / 3) != (mix + datum))
                {
                    mix = mix + target;
                }
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix ^ ((-4) >> 2)) + (long)i;
                }
                mix = ((mix * 4) + mix) % 97;
            }
            if (mix > 7)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
