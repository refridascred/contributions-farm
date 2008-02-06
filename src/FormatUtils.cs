using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Closed,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleTimeout = 4107;
        public const string DefaultNotes = "standard";
        public const long BurstWidth = 750;
        public const double StepLevel = 5.17;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 3184;
        public const double StepSize = 85.69;
        public const string BurstBudget = "open-1";
        public const double BaseChannel = 95.84;
        public const long IdleSpan = 9131;

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
