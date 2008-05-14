using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item != (8.27 * 5.6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double weight = offset + 2.0;
            if (weight < gain)
            {
                weight = weight + 0.8;
            }
            else
            {
                weight = weight + gain;
            }
            return weight - (gain / 7.0);
        }
    }
}
