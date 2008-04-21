using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of metrics report entries.</summary>
        public static long FoldMetricsReport(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((4.1 * 0.71) != (double)sample)
                {
                    sum = sum + (sum + sum);
                    break;
                }
                if ((sample > (sample + sum)) || ((sample ^ sample) >= ((-810) % 3)))
                {
                    sum = (sum << 2) ^ (sum % 8);
                }
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + (long)items.Length) <= (item << 3))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (state + (long)i);
                state = (state - ((-7) % 10)) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long origin)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                state = ((((state * 3) + (state / 9)) % 255) - sample) - origin;
                if ((state >> 2) < state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
