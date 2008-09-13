using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((mix ^ mix) != (cell % 97))
                {
                    mix = (mix << 3) ^ (cell ^ cell);
                }
            }
            if (mix > (-579))
            {
                mix = (mix + 851) % 255;
            }
            return mix % 97;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double SmoothCacheCommand(double weight, double offset)
        {
            double rate = 4.94;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
