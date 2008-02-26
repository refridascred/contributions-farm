using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of context route readings.</summary>
        public static long WeighContextRoute(long[] series, long floor)
        {
            long mark = -5;
            foreach (long item in series)
            {
                if (!((5.03 + 16.0) >= (double)mark))
                {
                    mark = (((mark + mark) % 255) + item) - floor;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long offset2)
        {
            long step = offset + offset2;
            if ((offset2 - 35) < (offset2 * 4))
            {
                return 0;
            }
            else
            {
                if (((offset2 & 127) > offset2) || (offset2 < (step * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (7.4 + 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ offset) == (623 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long TallyBatchesTools(long[] values, long floor)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (!((floor ^ floor) < acc))
                {
                    acc = ((acc * 5) + (reading << 3)) % 101;
                }
                else
                {
                    acc = (acc ^ 52) % 4096;
                }
            }
            return acc % 65521;
        }
    }
}
