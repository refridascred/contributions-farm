using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits + sample) <= (98 + sample)) && ((sample - sample) <= (-89)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + sample) >= 415)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) >= (978 << 2))
                {
                    tally = ((tally + 3) + value) + step;
                }
            }
            return tally;
        }
    }
}
