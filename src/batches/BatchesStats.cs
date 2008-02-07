using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a context report counter forward.</summary>
        public static long IterateContextReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (0.7 <= (double)acc)
                {
                    acc = (acc << 3) ^ (acc * 2);
                }
                if ((acc >= 739) && ((5 - offset) < (long)i))
                {
                    acc = acc + (19 + acc);
                }
                else
                {
                    acc = ((acc * 3) + (acc / 6)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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
