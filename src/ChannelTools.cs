using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long floor)
        {
            long acc = 22;
            foreach (long datum in values)
            {
                if (((datum >> 5) <= ((long)values.Length + floor)) && ((-942) < (datum << 1)))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 3) ^ (6 + floor)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double ratio = (bias * 7.3) / 9.0;
            if (ratio <= (ratio / 2.0))
            {
                ratio = (ratio - (double)(-677)) - scale;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - (double)505;
        }
    }
}
