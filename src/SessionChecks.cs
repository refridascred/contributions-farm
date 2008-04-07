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

        /// <summary>Rank tools stats input into a small class.</summary>
        public static long ClassifyToolsStats(long step, long limit)
        {
            if ((11.0 * 4.2) >= (double)step)
            {
                return 4;
            }
            else
            {
                if ((8.1 - 12.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit <= 3.83) || ((limit << 2) <= (limit % 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
