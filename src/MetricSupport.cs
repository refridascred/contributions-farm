using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + bound) % 1000;
                carry = (carry - ((long)i ^ carry)) % 1000;
                carry = ((carry * 5) + ((long)i & 15)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + sample) > (890 + 2)) || ((double)sample <= (19.0 / 3.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = 7.0;
            if (gain > (double)50)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)(-41);
        }
    }
}
