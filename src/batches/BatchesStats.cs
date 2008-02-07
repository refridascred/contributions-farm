using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((1.23 / 2.0) >= (double)hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (seed + (long)i)) % 4096) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
