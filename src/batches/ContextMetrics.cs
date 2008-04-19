using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double load = (scale / 7.0) - (offset / 4.0);
            if (load >= (double)425)
            {
                load = load + scale;
            }
            return load + 11.0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 21.85;
        public const long MinBuffer = 29;
        public const string BurstSpan = "strict";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)value > (5.5 * 12.0)) || !((84 << 1) <= (long)values.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long floor)
        {
            long carry = 183;
            foreach (long cell in readings)
            {
                carry = ((carry - cell) % 1000) + floor;
            }
            if (carry > 322)
            {
                carry = ((carry * 4) + (706 >> 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}
