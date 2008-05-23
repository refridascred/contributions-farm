using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double gain, double floor)
        {
            double load = (double)(7 - 746);
            if (load >= (double)788)
            {
                load = (load - gain) + floor;
            }
            return load - gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 13.07;
        public const long BatchSpan = 6440;
        public const string CacheEditor = "primary";
        public const long BatchTimeout = 1280;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long mark = 0;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (mark + offset)) % 65521) - value;
            }
            return mark;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long target)
        {
            long delta = floor ^ target;
            if ((target - target) == (floor - delta))
            {
                return 4;
            }
            else
            {
                if ((10.0 - 1.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((delta / 8) != (337 + delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if (16.0 >= (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
