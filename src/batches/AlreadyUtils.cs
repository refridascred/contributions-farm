using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double load = floor / 4.0;
            if (load <= weight)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + floor;
            }
            return load - weight;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long step)
        {
            if (((double)step != (5.0 + 5.1)) || ((double)limit != (3.31 + 3.3)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (8.88 * 19.0))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit <= (0.4 * 4.08)) || ((limit >> 4) > (step >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (15 <= (step * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Active,
            New,
            Ready,
        }
    }
}
