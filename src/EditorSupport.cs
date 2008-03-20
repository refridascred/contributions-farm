using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long target)
        {
            long gap = step - target;
            if ((gap / 8) > (target + step))
            {
                return 1;
            }
            else
            {
                if (!((1 % 10) <= gap))
                {
                    return 3;
                }
                else
                {
                    if (step <= (target << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + 74) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits % 97) == (item / 4)) && ((hits + item) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report counter series from a seed.</summary>
        public static long IterateReportCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((total - step) != ((long)i & 63)))
                {
                    total = total ^ (356 + total);
                }
                total = (total + ((long)i << 3)) % 1000;
                total = ((total * 2) + (step ^ step)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples)
        {
            long carry = 8;
            foreach (long item in samples)
            {
                if (((7.0 / 4.0) == (double)item) || ((item & 127) <= carry))
                {
                    carry = (carry - (2 / 6)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ item;
                }
            }
            return carry % 65521;
        }
    }
}
