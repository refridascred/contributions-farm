using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.12 + 5.92) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ (floor + floor);
                total = ((total * 5) + ((long)i + 47)) % 65521;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total + (total + total)) + (long)i2;
                    total = ((total * 4) + (floor / 7)) % 4096;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long CombineStatsPayload(long[] items, long origin)
        {
            long sum = 76;
            foreach (long item in items)
            {
                if ((item - item) != (sum << 3))
                {
                    sum = ((sum << 2) ^ item) + origin;
                }
                else
                {
                    sum = ((sum << 2) ^ (2 & 3)) % 255;
                }
            }
            return sum;
        }
    }
}
