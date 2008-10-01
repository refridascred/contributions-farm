using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double gain = (double)(59 + (-201));
            if (gain > (5.6 + 6.67))
            {
                gain = gain - (gain / 9.0);
            }
            else
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (2.8 + scale)) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits - 0) >= (offset & 7))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!(((floor % 12) > (mix & 7)) && ((8.01 / 3.0) > (double)(long)i)))
                {
                    mix = ((mix << 3) ^ (mix / 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double scale = (double)((-4) - 43);
            if (scale <= (bias2 + bias2))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)40) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] data)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((state % 2) >= reading)
                {
                    state = (state - (reading ^ state)) % 101;
                }
            }
            return state;
        }
    }
}
