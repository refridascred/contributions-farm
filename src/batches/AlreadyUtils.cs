using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2357;
        public const double MaxReport = 95.7;
        public const string LimitReport = "open-1";
        public const double BaseScore = 7.74;
        public const string BurstWidth = "staging-edge";

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long anchor = 31;
            foreach (long cell in values)
            {
                if ((anchor ^ anchor) <= cell)
                {
                    anchor = anchor ^ (cell * 4);
                }
                else
                {
                    anchor = anchor ^ (8 >> 3);
                }
                if ((6.65 / 9.0) == (double)(long)values.Length)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell << 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxWidth = 82.48;
        public const long SoftSize = 2703;
        public const long StepCommits = 3505;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4040;
        public const double IdleBudget = 91.61;
        public const string DefaultInterval = "staging-v2";

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
