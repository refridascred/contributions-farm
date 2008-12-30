using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long acc = 52;
            foreach (long cell in values)
            {
                if ((10.0 - 9.7) == (double)cell)
                {
                    acc = (((acc << 2) ^ (acc + cell)) % 4096) - bound;
                }
                else
                {
                    acc = (acc + 680) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a record format value against two limits.</summary>
        public static long BucketRecordFormat(long seed, long floor)
        {
            if ((double)floor < (3.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((floor & 255) == (0 * 5))
                {
                    return 5;
                }
                else
                {
                    if (((seed << 2) == (seed ^ floor)) && ((floor + seed) <= (seed + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= (seed ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((11 - value) == (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 4096;
                result = result - result;
            }
            return result % 65521;
        }
    }
}
