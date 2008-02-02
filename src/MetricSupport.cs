using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count editor buffer pairs that satisfy a relation.</summary>
        public static long MatchEditorBufferCount(long[] series)
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

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (((87 % 12) != (cur + cur)) || ((1.09 / 8.0) < (double)cur))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (1.7 * 5.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6783;
        public const double WindowCommits = 41.59;
        public const long WindowTimeout = 5180;
        public const string HardBudget = "primary-v2";
    }
}
