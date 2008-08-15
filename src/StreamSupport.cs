using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double rate = (double)(3 / 5);
            if (rate < (bias + rate))
            {
                rate = rate + (double)322;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate + (double)(-3);
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long seed)
        {
            long offset = origin - seed;
            if ((31 - offset) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) > (458 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin >= 9.56) || ((double)offset != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((841 < (offset + origin)) || ((seed + offset) > (origin + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
