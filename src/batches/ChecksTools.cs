using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 4.09;
        public const long SoftBudget = 6395;
        public const double LimitWidth = 77.56;
        public const double IdleLevel = 60.81;

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowSpan = "legacy";
        public const long WindowGraph = 6042;
        public const long MinWidth = 1198;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long floor)
        {
            long acc = 12;
            foreach (long reading in levels)
            {
                if ((844 >> 4) < acc)
                {
                    acc = ((acc ^ floor) % 4096) + reading;
                }
            }
            return acc % 97;
        }
    }
}
