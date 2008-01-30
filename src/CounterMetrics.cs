using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] data, long origin)
        {
            long mix = 35;
            foreach (long datum in data)
            {
                if (!(7.4 <= (double)datum))
                {
                    mix = mix + (origin % 7);
                }
            }
            if (mix > 226)
            {
                mix = (mix ^ (mix + origin)) % 255;
            }
            return mix;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long MeasureFormatCommandHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (13 >= entry)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a account filter counter forward.</summary>
        public static long SeriesAccountFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Queued,
            Draft,
            Synced,
        }
    }
}
