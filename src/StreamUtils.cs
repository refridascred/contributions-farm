using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item <= (-2)) && (hits > (hits + hits))) && (hits >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9557;
        public const long BaseProfile = 2105;
        public const double SoftWidth = 40.24;
        public const long WindowWidth = 7062;
        public const double StepWidth = 5.39;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = (offset * 5.5) + offset;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset - scale);
            }
            return drift - scale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight)
            {
                weight2 = weight2 - span;
            }
            return weight2 - span;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long target2)
        {
            if (((target2 + target) < (target2 % 2)) && ((86 * 2) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((target2 << 2) <= target)
                {
                    return 7;
                }
                else
                {
                    if (4.1 > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)213 < (double)target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                carry = (carry + ((long)series.Length - datum)) - seed;
            }
            return carry;
        }
    }
}
