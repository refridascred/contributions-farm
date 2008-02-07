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

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 9592;
        public const long DefaultSpan = 4988;
        public const double SoftTimeout = 56.62;
        public const long MinChannel = 1841;

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
