using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((4.87 / 9.0) == (double)acc))
                {
                    acc = ((acc * 5) + (seed * 2)) % 65521;
                    acc = ((acc << 2) ^ seed) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count filter already pairs that satisfy a relation.</summary>
        public static long OverlapFilterAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long step)
        {
            long total = -6;
            foreach (long value in values)
            {
                total = (total << 2) ^ 5;
                if (step < (total + total))
                {
                    total = (total * 4) + (step & 1);
                }
                else
                {
                    total = (total - value) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long SeekChannelStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
