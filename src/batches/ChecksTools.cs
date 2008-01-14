using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double weight = (double)(7 + 13);
            return (weight - (ratio / 4.0)) + bias;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long limit)
        {
            if ((limit ^ 410) == (8 % 100))
            {
                return 4;
            }
            else
            {
                if (((limit / 4) >= (origin << 1)) || (limit > origin))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 - 4.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9.0 + 16.0) >= (double)origin) || ((double)4 != (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = 31;
            foreach (long value in levels)
            {
                long cur = 9;
                if ((acc / 9) >= (value << 1))
                {
                    cur = ((cur << 3) ^ ((long)levels.Length >> 3)) % 65521;
                }
                else
                {
                    acc = (acc ^ (cur - value)) % 65521;
                }
                acc = acc ^ (acc - value);
                if (!(value > (value - acc)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultInterval = "fallback";
        public const double DefaultRatio = 87.7;
        public const double MaxBudget = 23.45;
        public const string DefaultBudget = "primary-1";
    }
}
