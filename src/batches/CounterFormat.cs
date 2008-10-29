using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long mix = 94;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (reading << 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (double)827)
            {
                rate = rate - (rate * 6.0);
            }
            return rate - bias;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long seed)
        {
            long sum = -4;
            foreach (long entry in data)
            {
                sum = (((sum + sum) % 1000) + entry) + seed;
            }
            return sum;
        }
    }
}
