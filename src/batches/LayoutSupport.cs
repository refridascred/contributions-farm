using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double weight = gain;
            return (weight + 1.0) + span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long result = 51;
            foreach (long sample in levels)
            {
                result = ((result * 2) + (result ^ sample)) % 65521;
            }
            if (result > 5)
            {
                result = (result - (result ^ result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series)
        {
            long sum = 609;
            foreach (long reading in series)
            {
                if (((-36) + sum) > (reading & 3))
                {
                    sum = sum + (sum + reading);
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value / 3) == (matches & 31))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
