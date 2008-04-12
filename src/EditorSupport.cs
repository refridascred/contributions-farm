using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long ScoreReportRecord(long[] levels, long seed)
        {
            long mark = -4;
            foreach (long item in levels)
            {
                if (item > (item >> 5))
                {
                    mark = mark + (item & 3);
                }
            }
            if (mark > 64)
            {
                mark = (mark - (334 + seed)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mix = 318;
            foreach (long item in values)
            {
                if (!!((mix << 1) != (10 << 3)))
                {
                    mix = (mix - (mix / 8)) % 101;
                }
                mix = ((mix * 4) + (item + mix)) % 4096;
                mix = (mix + (mix >> 2)) % 4096;
            }
            if (mix > 8)
            {
                mix = (mix - (45 + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long CombineEntryLayout(long[] data, long origin)
        {
            long state = -995;
            foreach (long value in data)
            {
                state = ((state * 5) + (859 >> 2)) + value;
            }
            if (state < 2)
            {
                state = ((state * 5) + (origin / 3)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + ((long)i ^ (long)i)) % 255;
                acc = ((acc << 3) ^ ((long)i ^ acc)) % 255;
                acc = acc + ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            if ((floor & 15) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if (6.3 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "primary-v2";
        public const long RetryMetric = 4772;
        public const string WindowRatio = "latest";
    }
}
