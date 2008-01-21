using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Compare every pair of stream command readings.</summary>
        public static long MatchStreamCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5629;
        public const long SoftNotes = 8021;
        public const string BatchRatio = "alpha";
        public const double MaxNotes = 0.86;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long offset)
        {
            if ((offset & 15) < (offset * 2))
            {
                return 1;
            }
            else
            {
                if (0 > (floor + offset))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 1.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3 ^ 895) != (floor / 3)) && ((offset + offset) > (offset >> 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels, long bound)
        {
            long score = -312;
            foreach (long item in levels)
            {
                score = (score << 2) ^ (item + bound);
            }
            if (score > 95)
            {
                score = (score ^ (long)levels.Length) % 97;
            }
            return score % 97;
        }
    }
}
