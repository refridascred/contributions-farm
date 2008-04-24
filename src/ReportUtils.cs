using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3724;
        public const long CacheToken = 9529;
        public const string HardWidth = "stable-edge";
        public const string WindowCount = "stable-edge";
        public const long BurstWidth = 9849;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 4243;
        public const long MaxWidth = 4012;
        public const string MaxScore = "legacy-v2";
        public const long BaseCluster = 4734;
        public const long SoftBudget = 7697;

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long TallyFarmStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < 2)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((1 - tally) < (tally + (long)samples.Length))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }
    }
}
