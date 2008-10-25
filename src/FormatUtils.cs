using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long total = 802;
            foreach (long item in samples)
            {
                if ((7.53 + 2.25) == (double)total)
                {
                    total = total - (item * 3);
                }
            }
            if (total < 48)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8651;
        public const long DefaultChecks = 4571;
        public const long CacheBudget = 7967;
        public const long BurstChecks = 1307;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph notes reading.</summary>
        public static double BlendGraphNotes(double bias, double floor)
        {
            double gain = (double)(8 / 4);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (floor + bias)) + (double)(long)i;
            }
            return gain + (double)(-728);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
