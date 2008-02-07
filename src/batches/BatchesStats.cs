using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((step - hits) > (hits >> 3)) || ((298 + hits) > (step / 7)))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 51;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (value - value)) % 4096;
                state = (state - value) % 1000;
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (state % 8)) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
