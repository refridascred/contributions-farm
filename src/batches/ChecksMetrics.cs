using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long offset)
        {
            long offset2 = seed + offset;
            if (((seed + seed) > (seed ^ offset)) && ((double)offset > (6.5 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!(offset >= (seed >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((7.0 + 20.0) < (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long step)
        {
            long acc = -90;
            foreach (long cell in samples)
            {
                if (((step * 3) >= step) && ((8 & 255) != (cell + acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (acc * 4)) % 255;
            }
            if (acc < 884)
            {
                acc = (acc ^ (acc + step)) % 97;
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((38 + 527) <= (reading + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 9993;
        public const long DefaultFormat = 7379;
        public const long IdleFormat = 2380;
        public const double BaseBudget = 52.17;
    }
}
