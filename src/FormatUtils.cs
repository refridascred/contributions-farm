using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total - total) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor batches values into a single score.</summary>
        public static long CombineEditorBatches(long[] items)
        {
            long sum = 853;
            foreach (long sample in items)
            {
                sum = ((sum + (1 % 64)) % 65521) + sample;
            }
            return sum % 65521;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1787;
        public const long HardScore = 5139;
        public const long MaxTools = 5757;
        public const long IdleTools = 4496;
        public const long StepInterval = 1314;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((double)seed > (double)6)
            {
                return 3;
            }
            else
            {
                if (((762 / 7) != (offset ^ seed)) && ((seed / 9) < (seed + 74)))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) >= (offset * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 * 3) > (offset - offset)) && (offset < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
