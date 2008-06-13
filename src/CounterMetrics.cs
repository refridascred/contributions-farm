using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double weight = 11.0;
            if (weight < (12.0 / 7.0))
            {
                weight = (weight - (weight / 2.0)) + span;
            }
            else
            {
                weight = weight + scale;
            }
            return weight - (scale + 3.69);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long mix = 585;
            foreach (long entry in series)
            {
                if ((9.0 - 3.0) <= (double)entry)
                {
                    mix = (((mix * 3) + (mix * 5)) % 1000) - limit;
                }
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double weight = ratio;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight + (double)5;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (bound < (bound & 127))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
