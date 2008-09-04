using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many layout tools samples are out of range.</summary>
        public static long AuditLayoutToolsOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((4 >> 4) == (reading + (-8)))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((matches & 3) != (matches >> 4)) || ((1.29 - 8.91) != (double)origin)) && ((matches - matches) <= matches))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Match up cluster account samples.</summary>
        public static long CompareClusterAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Active,
            Paused,
            Queued,
            Synced,
        }
    }
}
