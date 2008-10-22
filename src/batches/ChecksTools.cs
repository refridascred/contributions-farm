using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((7 >> 2) == (offset >> 5))
            {
                return 3;
            }
            else
            {
                if (((offset + offset) >= (42 % 7)) && ((offset >> 2) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((9.4 / 6.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "local-v2";
        public const long WindowSession = 7983;
        public const long HardSession = 2620;
        public const long RetryLevel = 5219;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) == (seed >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
