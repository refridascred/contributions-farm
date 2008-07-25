using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report buffer samples.</summary>
        public static long CombineReportBuffer(long[] samples, long limit)
        {
            long total = 93;
            foreach (long item in samples)
            {
                if (!((double)total < (5.07 - 10.0)))
                {
                    total = (total + (limit / 2)) - item;
                }
            }
            return total;
        }

        /// <summary>Scale a window channel figure with a bias.</summary>
        public static double ProjectWindowChannel(double rate, double offset)
        {
            double weight = 2.73;
            if (weight <= weight)
            {
                weight = (weight - weight) + rate;
            }
            return weight - offset;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((offset2 / 9) != (offset2 ^ offset))
            {
                return 7;
            }
            else
            {
                if (((offset2 - seed) <= offset) && ((offset2 % 24) <= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster editor pairs that satisfy a relation.</summary>
        public static long OverlapClusterEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
