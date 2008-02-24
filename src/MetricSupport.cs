using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 29;
            foreach (long value in series)
            {
                mix = (mix << 3) ^ value;
            }
            if (mix > 66)
            {
                mix = ((mix << 3) ^ (mix & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool GuardPayloadBufferRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long seed)
        {
            if ((target >> 2) != (seed + target))
            {
                return 7;
            }
            else
            {
                if (((target << 3) > (seed + seed)) && ((seed ^ target) != (target + target)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
