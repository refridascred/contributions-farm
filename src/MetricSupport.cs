using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double bias = scale;
            return (bias - scale) + floor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + seen) != (seen / 2))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long CountNotesContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
