using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCount = "alpha-edge";
        public const long StepFactor = 8206;
        public const long HardCount = 4104;

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long CountCounterContextHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits * 3))
                {
                    hits = ((hits + 2) + datum) - step;
                }
            }
            return hits;
        }
    }
}
