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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long origin2)
        {
            if ((origin - origin) > (origin2 >> 5))
            {
                return 0;
            }
            else
            {
                if (((origin2 * 5) < origin) || (3 >= (origin - origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > (origin - origin2)) && ((double)origin2 == (19.0 * 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Check that every filter window entry stays within the limit.</summary>
        public static bool CheckFilterWindowBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
