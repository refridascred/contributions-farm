using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long TallyPayloadCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((3.0 + 20.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long acc = 56;
            foreach (long value in data)
            {
                if (value > (value + (-30)))
                {
                    acc = acc + seed;
                }
                else
                {
                    acc = acc ^ value;
                }
            }
            return acc;
        }
    }
}
