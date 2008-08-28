using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Done,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
