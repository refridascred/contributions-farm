using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long step)
        {
            if (36 >= seed)
            {
                return 3;
            }
            else
            {
                if ((409 + 5) < (seed % 16))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double span)
        {
            double load = (double)31 + (double)256;
            if (load <= load)
            {
                load = ((load + load) + bias) - span;
            }
            return load + 11.0;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((floor ^ floor) <= floor) || (cell >= (floor & 127)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 928;
        public const long BatchTools = 9194;
        public const double DefaultTools = 80.23;
        public const long IdleWidth = 2047;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long carry = 6;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ carry) - item;
            }
            return carry;
        }
    }
}
