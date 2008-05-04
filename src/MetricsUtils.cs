using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double bias = (double)(52 + 291);
            if (bias >= span)
            {
                bias = (bias + (span + span)) - weight;
            }
            return bias - (double)0;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of githubfarm payload entries.</summary>
        public static long WeighGithubfarmPayload(long[] series, long step)
        {
            long state = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)state)
                {
                    state = (state - (step + sample)) % 1000;
                }
                if ((step - state) > ((-32) >> 2))
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = state ^ (state / 3);
            }
            return state % 97;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double gain2 = 8.47 * 11.0;
            if (gain2 >= (gain2 + gain))
            {
                gain2 = gain2 - (gain2 * 0.7);
            }
            else
            {
                gain2 = gain2 + (6.39 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
