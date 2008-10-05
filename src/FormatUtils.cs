using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                if (7 < mix)
                {
                    mix = (mix ^ (origin + mix)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseCount = 6053;
        public const long LimitEditor = 8438;
        public const long BatchSize = 1935;
        public const long HardInterval = 2288;
        public const long CacheWidth = 7176;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = (mix + ((long)items.Length - 394)) % 97;
                if ((reading / 7) <= mix)
                {
                    mix = mix + (mix + reading);
                }
            }
            if (mix < 9)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
