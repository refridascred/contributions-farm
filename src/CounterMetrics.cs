using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items, long seed)
        {
            long mix = 69;
            foreach (long datum in items)
            {
                mix = ((mix ^ (datum - mix)) % 255) - seed;
            }
            if (mix > 518)
            {
                mix = (mix ^ (9 + mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Scale a context session figure with a bias.</summary>
        public static double ProjectContextSession(double scale, double floor)
        {
            double scale2 = 8.19;
            if (scale2 > (scale2 * 4.0))
            {
                scale2 = (scale2 - (double)991) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long state = -6;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (bound % 5)) - datum;
            }
            return state;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
