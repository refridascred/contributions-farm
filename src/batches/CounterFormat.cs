using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long floor)
        {
            long edge = target + floor;
            if ((target >> 1) < (target ^ target))
            {
                return 1;
            }
            else
            {
                if ((floor + 213) <= (target >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((edge - target) < (floor << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
