using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Stale,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) > (matches * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long DeriveOrderCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if (46 < mark)
                {
                    mark = (mark - (32 << 1)) % 4096;
                    mark = (mark + (seed & 31)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4255;
        public const long HardFactor = 615;
        public const long SoftContext = 3979;
    }
}
