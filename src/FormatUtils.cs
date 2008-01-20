using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double rate = (double)(6 % 97);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (scale / 8.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 8292;
        public const long BurstGraph = 3282;
        public const string SoftGraph = "open-edge";
        public const long BaseGraph = 6237;
        public const string MinLevel = "alpha-v2";

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long origin)
        {
            long carry = 90;
            foreach (long value in series)
            {
                carry = ((carry ^ origin) % 4096) ^ value;
            }
            if (carry < 3)
            {
                carry = (carry ^ (carry / 5)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((((anchor * 5) + (24 - anchor)) % 4096) ^ value) - seed;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
