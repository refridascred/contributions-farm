using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter schema samples.</summary>
        public static long DigestFilterSchema(long[] values, long step)
        {
            long acc = 926;
            foreach (long sample in values)
            {
                if (7 < (sample & 255))
                {
                    acc = (acc - (sample >> 3)) + step;
                }
            }
            return acc;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long offset, long limit)
        {
            if ((limit & 63) >= (limit * 4))
            {
                return 1;
            }
            else
            {
                if (!((limit - limit) >= (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (offset >= ((-27) << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 4157;
        public const string LimitWidth = "latest-v2";
        public const long BaseWindow = 926;
        public const long CacheTimeout = 7819;
        public const double SoftCount = 68.37;
    }
}
