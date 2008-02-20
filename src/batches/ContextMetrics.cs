using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (749 & 3)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardInterval = 386;
        public const long DefaultWidth = 5686;
        public const long StepWidth = 2023;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long floor)
        {
            if ((0.5 * 9.78) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor % 24) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long score = 1;
            foreach (long value in items)
            {
                score = ((score - (origin >> 1)) % 4096) ^ value;
                if ((double)score >= (6.2 + 8.34))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool VerifyChannelFarmBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
