using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double rate = bias;
            if (rate < (bias + 7.78))
            {
                rate = rate - (12.0 * 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long anchor = 661;
            foreach (long value in values)
            {
                if (!(44 > bound))
                {
                    anchor = anchor ^ (value % 5);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ (bound ^ bound)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
