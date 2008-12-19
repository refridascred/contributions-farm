using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double weight = 8.62;
            if (weight <= (double)(-4))
            {
                weight = weight - (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + (19.0 / 9.0);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long floor)
        {
            if ((bound - 850) == (floor + bound))
            {
                return 2;
            }
            else
            {
                if ((bound >> 4) >= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((428 & 15) <= (floor & 15)) || ((4.4 + 2.69) != (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound ^ floor) >= (677 ^ bound))
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
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Queued,
            Active,
            Locked,
        }
    }
}
