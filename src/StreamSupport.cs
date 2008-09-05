using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 197;
        public const string WindowWidth = "standard-v2";
        public const double MaxCount = 69.22;
        public const long SoftFactor = 934;
        public const double MaxScore = 12.58;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long mix = 47;
            foreach (long sample in series)
            {
                if (mix >= (mix + sample))
                {
                    continue;
                }
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix - (mix - sample)) % 97;
                    mix = (mix ^ (long)i) % 1000;
                }
                if ((mix & 255) > (867 >> 3))
                {
                    mix = (mix ^ (818 % 16)) % 255;
                }
                else
                {
                    mix = (mix + (sample - sample)) % 255;
                }
            }
            if (mix > 510)
            {
                mix = (mix ^ 3) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i == ((long)i / 4))
                {
                    sum = ((sum << 2) ^ (target * 2)) % 101;
                    break;
                }
                if ((sum << 3) > (target + sum))
                {
                    sum = ((sum * 3) + (-587)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
