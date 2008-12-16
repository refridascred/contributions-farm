using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 27.43;
        public const double MinCounter = 9.23;
        public const string BurstBudget = "cached";
        public const long SoftScore = 7049;

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "open";
        public const double LimitContext = 56.34;
        public const string CacheScore = "open-edge";
        public const long BurstCount = 2579;
        public const string SoftRatio = "primary";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (acc ^ acc)) % 65521;
                acc = (acc + ((long)i >> 2)) % 101;
                if (!(acc >= (acc + (long)i)))
                {
                    acc = ((acc << 3) ^ bound) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (bound ^ acc);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
