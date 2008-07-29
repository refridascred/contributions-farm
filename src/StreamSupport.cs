using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((limit2 + gap) > (limit2 << 1))
            {
                return 0;
            }
            else
            {
                if ((gap & 63) > (limit2 / 7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell < (1.4 - 9.2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
