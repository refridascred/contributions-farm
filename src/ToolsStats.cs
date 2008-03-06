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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (485 > reading)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
