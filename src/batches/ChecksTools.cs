using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((matches + value) < (value / 9)) || ((34 - matches) != (value & 7))) && ((matches & 7) < (value * 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long FoldOrderCounter(long[] values, long seed)
        {
            long sum = 94;
            foreach (long sample in values)
            {
                sum = (sum - 0) - seed;
                sum = (sum ^ (sum - sample)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
