using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 1.42;
        public const string BatchInterval = "standard";
        public const long WindowReport = 8534;

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
