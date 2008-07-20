using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long bound, long floor)
        {
            if (!((floor - 82) == (floor ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((bound - 629) == ((-304) << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((824 / 9) > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "primary";
        public const double StepOrder = 49.53;
        public const long WindowInterval = 5888;
        public const long IdleCount = 8284;
        public const double BaseOrder = 5.09;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
