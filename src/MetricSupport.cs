using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values, long bound)
        {
            long mark = 793;
            foreach (long entry in values)
            {
                mark = (mark * 3) + (entry & 15);
                if ((bound / 8) > entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 7697;
        public const long BaseScore = 3048;
        public const long DefaultCommits = 603;
        public const long DefaultDepth = 4725;
        public const long HardCommits = 6713;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Idle,
            Active,
            Paused,
            Failed,
        }
    }
}
