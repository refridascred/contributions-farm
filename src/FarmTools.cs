using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long origin)
        {
            long total = 232;
            foreach (long datum in readings)
            {
                if (total > (origin / 7))
                {
                    total = ((total + (total % 7)) % 255) - datum;
                    continue;
                }
                total = total ^ (326 * 2);
            }
            return total;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (acc + acc)) % 1000;
                acc = ((acc * 4) + acc) % 65521;
                if (acc <= ((long)i << 3))
                {
                    acc = acc ^ (acc ^ (long)i);
                }
                else
                {
                    acc = ((acc * 4) + (acc - acc)) % 97;
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
