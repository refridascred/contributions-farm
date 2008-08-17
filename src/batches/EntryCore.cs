using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Active,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "stable-edge";
        public const long MaxCount = 1968;
        public const long BaseCluster = 4870;
        public const long StepCluster = 1004;

        /// <summary>Derive the next tools cache value from a seed.</summary>
        public static long StepToolsCache(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (state < (step * 4))
                {
                    state = (state << 3) ^ (6 << 1);
                    break;
                }
                else
                {
                    state = (state - 0) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
