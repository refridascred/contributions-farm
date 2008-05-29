using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long TallyMetricsSessionMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count < (441 + value))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            New,
            Active,
            Paused,
            Synced,
        }
    }
}
