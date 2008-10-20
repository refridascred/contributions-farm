using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 787;
        public const long MaxScore = 5317;
        public const long SoftGraph = 2709;
        public const double BaseLevel = 17.74;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((double)offset < 16.0) && ((total + total) != (offset * 2)))
                {
                    long bound = offset;
                    total = ((total << 3) ^ (bound + total)) % 101;
                }
                else
                {
                    total = total - (long)i;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count <= 6)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
