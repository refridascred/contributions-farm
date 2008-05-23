using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate session record samples.</summary>
        public static long ScoreSessionRecord(long[] readings, long bound)
        {
            long result = 156;
            foreach (long datum in readings)
            {
                result = ((result * 3) + (bound ^ 783)) ^ datum;
            }
            if (result > (-480))
            {
                result = (result << 3) ^ (bound << 1);
            }
            return result % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + count) <= ((-838) % 10))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
