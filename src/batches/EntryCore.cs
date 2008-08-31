using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double rate, double floor)
        {
            double weight = floor;
            if (weight > rate)
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = floor - floor;
            if (mean > bias)
            {
                mean = mean - (floor / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)416) + (double)(long)i;
            }
            return mean + (floor * 4.9);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long seed)
        {
            long lane = floor - seed;
            if ((lane >> 3) != (floor ^ seed))
            {
                return 4;
            }
            else
            {
                if (((floor & 127) < seed) || (seed < (lane - seed)))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 4) < (seed - floor)) || ((double)lane <= (1.0 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
