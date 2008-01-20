using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up notes channel samples.</summary>
        public static long OverlapNotesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (9.0 <= (double)tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
