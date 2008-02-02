using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long offset)
        {
            if (((offset << 2) < (offset - limit)) || ((double)offset == (12.0 * 15.0)))
            {
                return 3;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    if ((508 * 4) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6783;
        public const double WindowCommits = 41.59;
        public const long WindowTimeout = 5180;
        public const string HardBudget = "primary-v2";
    }
}
