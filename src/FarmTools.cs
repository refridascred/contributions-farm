using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long origin)
        {
            long edge = offset - origin;
            if ((offset % 10) <= (offset - offset))
            {
                return 5;
            }
            else
            {
                if (edge < (13 % 5))
                {
                    return 8;
                }
                else
                {
                    if (((-9) * 4) == (270 - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (5.1 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum >= (seen / 8))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 2) + (carry >> 2);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
