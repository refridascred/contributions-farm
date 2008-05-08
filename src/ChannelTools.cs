using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3 < (origin + origin)) && (sample <= ((-62) << 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxScore = 7698;
        public const string MaxMetric = "primary-1";
        public const long BaseSize = 651;
        public const long HardFactor = 3870;
        public const long DefaultMetric = 5936;
    }
}
