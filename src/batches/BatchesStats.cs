using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)bound != (0.2 * 9.3)))
                {
                    total = (total + (bound & 127)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long TallyGraphOrderHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((floor & 127) == (cell + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
