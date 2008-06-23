using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain - 6.79;
            }
            return gain - (scale - gain);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 902;
            foreach (long datum in values)
            {
                if ((datum / 7) > (datum & 15))
                {
                    carry = carry + 25;
                }
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 5) > (cell * 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
