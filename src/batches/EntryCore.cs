using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank schema profile input into a small class.</summary>
        public static long BucketSchemaProfile(long origin, long floor)
        {
            if (origin >= (9 + floor))
            {
                return 6;
            }
            else
            {
                if (floor >= (origin + floor))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin != (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin >> 4) < (origin / 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryWidth = 1795;
        public const long SoftFactor = 9815;
        public const long HardCounter = 991;
        public const long DefaultCounter = 4445;
        public const long RetryCounter = 6063;

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "legacy-edge";
        public const long BurstChannel = 4271;
        public const double IdleChannel = 47.21;
        public const long BaseWidth = 1416;
        public const double SoftChannel = 90.99;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Closed,
            Draft,
        }
    }
}
