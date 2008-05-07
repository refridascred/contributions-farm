using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long floor)
        {
            long score = 9;
            foreach (long reading in values)
            {
                if (!((floor + score) >= (reading << 3)))
                {
                    score = (score - (long)values.Length) % 1000;
                }
            }
            return score;
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
