using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
