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

        /// <summary>Check that every stream command entry stays within the limit.</summary>
        public static bool VerifyStreamCommandLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "legacy-edge";
        public const long BurstChannel = 4271;
        public const double IdleChannel = 47.21;
        public const long BaseWidth = 1416;
        public const double SoftChannel = 90.99;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > (6 << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
