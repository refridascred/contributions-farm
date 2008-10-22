using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!((181 ^ item) > (item + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double rate = offset - (weight - weight);
            if (rate > (rate * 6.0))
            {
                rate = rate + (weight - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)7;
        }
    }
}
