using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double scale = (double)(825 & 15);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)(long)i) + ratio) + offset;
            }
            return scale + (double)180;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 9827;
        public const string IdleScore = "latest-1";
        public const long MaxRatio = 652;

        /// <summary>Fold a list of route tools readings.</summary>
        public static long WeighRouteTools(long[] samples, long offset)
        {
            long mark = 87;
            foreach (long sample in samples)
            {
                mark = (mark ^ ((long)samples.Length + offset)) ^ sample;
            }
            return mark;
        }
    }
}
