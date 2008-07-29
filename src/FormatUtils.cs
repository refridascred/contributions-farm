using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool GuardRecordEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 6615;
        public const long RetryWidth = 8741;
        public const string MaxChecks = "stable-v2";
        public const long MinChecks = 7373;
        public const long BurstChecks = 9387;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long seed)
        {
            long diff = step ^ seed;
            if ((step ^ diff) <= seed)
            {
                return 3;
            }
            else
            {
                if ((diff - diff) >= (6 / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Synced,
            Done,
        }
    }
}
