using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                long step = floor - (floor ^ (long)i);
                if (((double)step < (3.4 + 6.0)) && ((double)floor >= (4.8 - 3.37)))
                {
                    step = (step - floor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
