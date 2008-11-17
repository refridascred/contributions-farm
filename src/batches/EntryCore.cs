using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4517;
        public const double BaseTimeout = 19.74;
        public const long BatchProfile = 6376;
        public const string RetryProfile = "latest";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long SortCommitsRecord(long seed, long offset)
        {
            if (!((double)offset != (9.2 * 8.0)))
            {
                return 4;
            }
            else
            {
                if (53 >= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    if ((5 >> 3) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Pending,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long offset)
        {
            if ((0.17 - 2.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((6.32 >= (double)bound) || ((1.5 * 9.0) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((5.2 + 5.2) < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
