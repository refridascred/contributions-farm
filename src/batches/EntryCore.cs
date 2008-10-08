using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ (-39)) > (value * 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics channel values into a single score.</summary>
        public static long TallyMetricsChannel(long[] samples)
        {
            long mix = 553;
            foreach (long item in samples)
            {
                mix = mix + 778;
                if ((mix > (mix << 2)) && ((item + mix) < (item ^ item)))
                {
                    break;
                }
            }
            if (mix > 49)
            {
                mix = ((mix * 5) + (mix << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a command filter reading by value.</summary>
        public static long FindCommandFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultLevel = 595;
        public const long BurstBudget = 2161;
        public const long BaseBudget = 2275;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
