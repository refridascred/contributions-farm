using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics context readings against a rule.</summary>
        public static long TallyMetricsContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + 4) > (datum ^ 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 8119;
        public const long HardSchema = 4377;
        public const long MinSchema = 4972;
        public const double MaxSchema = 55.88;
        public const long LimitBudget = 4274;
    }
}
