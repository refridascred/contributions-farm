using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (3.79 * 3.9))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

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
