using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double gain2 = (gain * 8.1) * 7.0;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - (gain2 * 5.1)) + (double)(long)i) - offset;
            }
            return gain2 + gain;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long floor)
        {
            long score = 3;
            foreach (long sample in series)
            {
                score = (score + (sample + 30)) - floor;
            }
            if (score < 30)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 97;
        }
    }
}
