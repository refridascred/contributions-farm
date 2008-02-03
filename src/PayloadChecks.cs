using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long step)
        {
            long state = -41;
            foreach (long cell in values)
            {
                if (!((state + cell) <= (state ^ step)))
                {
                    state = state - (16 + cell);
                }
            }
            return state;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 127) <= ((long)values.Length - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Synced,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Done,
            Idle,
        }
    }
}
