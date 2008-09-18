using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryInterval = 39.33;
        public const string BatchCache = "staging-edge";
        public const string RetrySize = "legacy";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((bound + value) <= (bound & 255)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Synced,
            Queued,
            Paused,
        }
    }
}
