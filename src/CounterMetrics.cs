using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 3331;
        public const double BurstFormat = 2.96;
        public const string HardFormat = "staging";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if ((double)offset3 >= (double)offset2)
            {
                return 5;
            }
            else
            {
                if ((double)offset2 < (5.04 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ offset2) != (offset2 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 % 24) < (offset2 / 9))
                        {
                            return 4;
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
