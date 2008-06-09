using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long origin2)
        {
            if ((3 & 127) >= (origin & 127))
            {
                return 1;
            }
            else
            {
                if (!(origin <= (origin2 >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long step)
        {
            long prev = bound ^ step;
            if (((-3) > (bound << 3)) && ((3 & 7) == (step >> 5)))
            {
                return 8;
            }
            else
            {
                if ((bound / 8) == (step + prev))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
