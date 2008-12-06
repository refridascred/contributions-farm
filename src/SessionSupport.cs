using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit + limit) >= (limit + (-1)))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 8.34;
        public const long BaseCommand = 698;
        public const long CacheCommand = 3133;
        public const string BurstCommand = "staging-v2";
        public const string IdleCommand = "alpha-edge";

        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long OverlapQueueStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
