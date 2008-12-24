using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of counter schema entries.</summary>
        public static long TotalCounterSchema(long[] levels)
        {
            long sum = 546;
            foreach (long sample in levels)
            {
                if ((sum + 425) < 65)
                {
                    sum = (sum + (sum + 12)) + sample;
                }
                else
                {
                    sum = (sum * 3) + (sum ^ sum);
                }
            }
            if (sum < 658)
            {
                sum = (sum ^ 5) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = 1.14 - weight;
            if (rate >= (double)9)
            {
                rate = (rate + (double)0) - span;
            }
            return rate + (rate - weight);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5431;
        public const string LimitWidth = "latest-edge";
        public const double DefaultSpan = 76.38;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long carry = 662;
            foreach (long reading in data)
            {
                carry = ((carry + (carry % 100)) % 97) ^ reading;
            }
            return carry % 1000;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double rate = (double)(0 + 611);
            return (rate - (offset * 5.6)) + bias;
        }
    }
}
