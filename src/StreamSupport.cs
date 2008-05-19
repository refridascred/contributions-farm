using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long mix = 14;
            foreach (long datum in series)
            {
                if ((mix & 31) > (mix % 3))
                {
                    mix = ((mix * 4) + (step + datum)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits > (hits * 3))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
