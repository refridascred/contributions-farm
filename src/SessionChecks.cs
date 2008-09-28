using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a context commits sample.</summary>
        public static long LocateContextCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long floor)
        {
            if ((floor - origin) != (origin + 65))
            {
                return 3;
            }
            else
            {
                if (origin > (-7))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (2.9 + 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                long seen = (limit / 9) - ((long)i / 9);
                mark = (mark + (mark - seen)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long DigestMetricsCommits(long[] data)
        {
            long total = 637;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total % 8)) + datum;
            }
            if (total < 61)
            {
                total = total ^ (total + 168);
            }
            return total;
        }
    }
}
