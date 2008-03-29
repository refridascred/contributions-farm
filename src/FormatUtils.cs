using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long sum = 42;
            foreach (long value in levels)
            {
                if (sum >= ((long)levels.Length * 3))
                {
                    sum = ((sum << 2) ^ (sum >> 4)) % 97;
                }
                sum = (sum * 3) + (sum + value);
            }
            return sum % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (seed < (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long origin2)
        {
            if ((double)origin2 != (8.0 + 10.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin2 == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long total = 6;
            foreach (long sample in values)
            {
                if (!((total - sample) != (sample + target)))
                {
                    total = (total ^ (target % 2)) % 1000;
                }
                if ((1.48 + 8.7) < (double)target)
                {
                    total = total + target;
                }
                else
                {
                    total = (total - (sample >> 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "cached-v2";
        public const long RetryAccount = 5796;
        public const string MaxAccount = "staging-edge";

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
