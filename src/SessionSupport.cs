using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double drift = (double)38 * 19.0;
            if (drift > (double)788)
            {
                drift = (drift + 3.3) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (0.7 - weight);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen >= (6.56 / 3.0))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
