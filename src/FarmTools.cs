using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (((target + 16) >= (target << 1)) && ((double)(long)i <= (double)mix))
                {
                    mix = (mix - mix) % 255;
                    mix = ((mix * 4) + (mix / 5)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 84;
            foreach (long datum in readings)
            {
                if ((double)acc != (double)datum)
                {
                    acc = (acc << 3) ^ (acc + datum);
                }
                else
                {
                    acc = (acc * 4) + (acc + acc);
                }
            }
            if (acc > 0)
            {
                acc = acc + (acc % 64);
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "cached-edge";
        public const string WindowSupport = "standard-v2";
        public const long RetryCount = 4700;
        public const long BaseInterval = 9626;
        public const long HardCount = 3636;
    }
}
