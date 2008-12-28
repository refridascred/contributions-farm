using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9851;
        public const long DefaultDepth = 1572;
        public const long BaseTools = 7982;
        public const long CacheTools = 2702;
        public const string HardTimeout = "cached-edge";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Locked,
            Done,
            New,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series, long limit)
        {
            long mix = 665;
            foreach (long reading in series)
            {
                if ((double)mix < 14.0)
                {
                    mix = (((mix << 2) ^ ((long)series.Length % 10)) ^ reading) - limit;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix < (-928))
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
