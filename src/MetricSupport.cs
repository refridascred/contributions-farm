using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long target)
        {
            long edge = bound + target;
            if (((target + bound) > 915) && ((edge & 255) == (target + bound)))
            {
                return 5;
            }
            else
            {
                if (4.6 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of schema checks readings.</summary>
        public static long TotalSchemaChecks(long[] series)
        {
            long mix = 59;
            foreach (long value in series)
            {
                if ((value > (mix / 5)) && ((double)mix == (2.0 * 7.0)))
                {
                    break;
                }
                else
                {
                    mix = (mix * 3) + (8 << 2);
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ (value + value)) % 101;
            }
            return mix;
        }
    }
}
