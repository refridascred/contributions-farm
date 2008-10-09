using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 1741;
        public const long DefaultLevel = 3661;
        public const long IdleDepth = 8853;
        public const long MaxReport = 9309;
        public const long CacheLevel = 2594;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next channel filter value.</summary>
        public static double SmoothChannelFilter(double weight, double span)
        {
            double drift = 8.46 * 5.46;
            return (drift + (weight - weight)) + span;
        }
    }
}
