using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long score = 51;
            foreach (long datum in readings)
            {
                score = ((score * 4) + (264 ^ datum)) % 101;
                score = ((score << 3) ^ offset) % 101;
            }
            return score % 4096;
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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Draft,
            Paused,
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
