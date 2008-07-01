using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxLevel = "primary";
        public const long HardSize = 9510;
        public const double SoftCluster = 2.51;
        public const string RetryScore = "open-v2";
        public const long MaxCluster = 8917;

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double gain = (double)(313 % 12);
            return (gain + offset) + rate;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double mean = (double)((-573) + 6);
            if (mean <= (double)66)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + (rate / 3.0);
            }
            return mean - (double)46;
        }

        /// <summary>Roll a account already counter forward.</summary>
        public static long IterateAccountAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((mix << 1) >= (seed % 64)) && ((seed - 5) > 93))
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
                else
                {
                    mix = (mix + (mix & 3)) % 4096;
                    mix = (mix << 3) ^ (mix - 730);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
