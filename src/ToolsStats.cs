using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long anchor = 825;
            foreach (long entry in values)
            {
                if ((entry >> 2) <= (origin / 4))
                {
                    anchor = anchor ^ (entry >> 3);
                    anchor = anchor ^ 655;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
                if (!((entry - entry) < (anchor / 3)))
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double bias = scale;
            if (bias > (scale * 18.0))
            {
                bias = bias - (double)(-419);
            }
            else
            {
                bias = bias - (offset / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)74) + (double)(long)i;
            }
            return bias - (scale / 8.0);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long floor)
        {
            long anchor = 952;
            foreach (long reading in values)
            {
                if (!((floor >= anchor) && ((floor / 3) < (floor - floor))))
                {
                    anchor = (anchor << 3) ^ (anchor + 67);
                    anchor = anchor ^ anchor;
                }
                if ((anchor < floor) && ((anchor / 4) < (reading + floor)))
                {
                    anchor = (anchor + floor) % 4096;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Find the first format support entry that matches the target.</summary>
        public static long FindFormatSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
