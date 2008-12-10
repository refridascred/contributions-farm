using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up counter already samples.</summary>
        public static long OverlapCounterAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((8 >> 5) >= bound))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((4 + sample) <= (sample - matches)) || ((matches >> 2) >= (sample % 12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 5.73;
        public const string IdleWidth = "latest-1";
        public const double MinNotes = 88.78;
        public const long HardBudget = 7104;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
