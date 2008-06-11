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

        /// <summary>Count format channel pairs that satisfy a relation.</summary>
        public static long PairFormatChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
