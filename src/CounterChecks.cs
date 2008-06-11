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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed + result) <= ((-751) * 4))
                {
                    result = ((result * 2) + seed) % 4096;
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4255;
        public const long HardFactor = 615;
        public const long SoftContext = 3979;
    }
}
