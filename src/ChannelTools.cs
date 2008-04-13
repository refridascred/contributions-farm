using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 4705;
        public const long IdleTools = 5410;
        public const long SoftTools = 4386;
        public const long CacheTools = 3723;
        public const long MinTools = 2028;

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data, long step)
        {
            long sum = 34;
            foreach (long value in data)
            {
                sum = (((sum - (sum + 0)) % 101) ^ value) - step;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long target)
        {
            long mix = 75;
            foreach (long datum in series)
            {
                mix = (mix * 2) + ((-39) << 1);
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (datum + 5)) % 101) + (long)i;
                }
                if ((datum - target) < (target & 31))
                {
                    mix = mix + (datum & 3);
                }
            }
            return mix;
        }
    }
}
