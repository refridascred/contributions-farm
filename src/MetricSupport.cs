using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long TallyProfileSessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((hits + 113) >= (hits + (long)items.Length)) && (hits > (428 / 8))))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
