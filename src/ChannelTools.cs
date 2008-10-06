using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((14.0 + 8.01) != (double)datum) || (datum >= (datum - 927))) && ((datum >= (553 / 7)) && ((double)datum <= (3.7 / 7.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                if (((long)samples.Length + carry) != (datum % 8))
                {
                    carry = (carry + (94 + carry)) % 97;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 448;
            foreach (long datum in series)
            {
                if ((double)mix <= (10.0 + 0.93))
                {
                    mix = ((mix - 2) % 101) - datum;
                }
                else
                {
                    mix = mix ^ (678 + 10);
                }
            }
            return mix % 1000;
        }
    }
}
