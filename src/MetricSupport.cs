using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long TallyStreamSchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((12.0 - 13.0) <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits + reading) <= (hits + 714)) && ((hits + reading) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
