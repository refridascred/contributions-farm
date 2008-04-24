using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Check that every metric batch entry stays within the limit.</summary>
        public static bool CheckMetricBatchBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
