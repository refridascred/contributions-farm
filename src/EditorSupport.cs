using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (3 << 1))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen / 5) != (datum % 60)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route schema entries.</summary>
        public static long TotalRouteSchema(long[] levels, long offset)
        {
            long total = 72;
            foreach (long datum in levels)
            {
                if (((-524) + offset) < 2)
                {
                    total = ((total + (long)levels.Length) % 97) + datum;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long limit)
        {
            if ((limit % 100) > limit)
            {
                return 6;
            }
            else
            {
                if (0 >= (limit >> 2))
                {
                    return 8;
                }
                else
                {
                    if (((limit % 2) > (limit ^ limit)) && ((limit * 2) <= target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target > (limit ^ target)) || ((795 * 4) == (limit * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long StepAlreadyChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < ((-1) % 64))
                {
                    acc = (acc << 2) ^ (72 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
