using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 5499;
        public const long WindowBudget = 9013;
        public const long BaseSession = 9876;
        public const double IdleWidth = 73.24;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            New,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (anchor % 16)) % 97;
                anchor = (anchor << 3) ^ (limit << 1);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long TotalBatchesBatch(long[] data, long origin)
        {
            long carry = 39;
            foreach (long cell in data)
            {
                carry = (((carry << 2) ^ (carry + 56)) % 1000) ^ cell;
            }
            if (carry > 55)
            {
                carry = carry - (carry - origin);
            }
            return carry;
        }
    }
}
