using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((8 <= (count + entry)) && ((double)count > (double)entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 82;
            foreach (long item in series)
            {
                result = result ^ (result - (long)series.Length);
                if ((93 ^ result) >= (item + result))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Ready,
            Active,
            Closed,
            Locked,
        }
    }
}
