using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long result = 54;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - (item - 955)) % 101) + (long)i;
                    result = ((result << 3) ^ item) % 101;
                }
                if ((385 - item) != (item + item))
                {
                    result = (result * 5) + (result / 8);
                }
            }
            if (result > 624)
            {
                result = (result + (3 << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Count account metrics pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next contributi window value from a seed.</summary>
        public static long RollContributiWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                    carry = carry + (floor / 2);
                }
                if ((((long)i << 3) <= carry) || ((double)floor != (8.0 - 4.0)))
                {
                    carry = (carry ^ (278 * 3)) % 65521;
                }
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
