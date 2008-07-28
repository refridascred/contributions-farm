using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long seed)
        {
            if (!((5.4 / 7.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if (((seed + target) >= 61) || ((208 / 4) >= target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 8.72)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((732 << 1) <= (target & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            if ((floor & 3) > (988 >> 1))
            {
                return 6;
            }
            else
            {
                if ((seed % 97) >= (964 - floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (5 < entry)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
