using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - 750) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] levels, long origin)
        {
            long anchor = 23;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (anchor / 6)) ^ sample) + origin;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Idle,
            Locked,
            Retry,
        }
    }
}
