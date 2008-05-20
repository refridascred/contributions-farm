using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long CombineAccountSupport(long[] items)
        {
            long carry = 23;
            foreach (long cell in items)
            {
                if ((double)cell <= 1.3)
                {
                    carry = (carry << 2) ^ (cell - carry);
                    continue;
                }
                if (((cell % 24) != (carry >> 2)) || ((9.4 / 4.0) == (double)carry))
                {
                    carry = (carry * 4) + (cell & 15);
                }
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ (71 + carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long offset)
        {
            if (target <= (9 - target))
            {
                return 0;
            }
            else
            {
                if ((348 - target) <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((0.36 - 4.0) >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) > ((-803) / 7)) || ((59 * 2) <= offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - seen) >= (seen - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up editor support samples.</summary>
        public static long MatchEditorSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
