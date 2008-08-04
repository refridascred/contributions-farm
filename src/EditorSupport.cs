using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter token entries that pass the check.</summary>
        public static long AuditFilterTokenGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item - item) < (step - step)) && ((0.7 + 3.7) <= (double)step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseInterval = 3278;
        public const string LimitTimeout = "local";
        public const string DefaultCount = "cached-edge";
        public const string BurstAccount = "strict-1";
        public const long RetrySpan = 9004;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (total << 3)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double AdjustLayoutCommand(double scale, double bias)
        {
            double load = bias;
            if (load > scale)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + load;
        }
    }
}
