using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long offset)
        {
            long sum = 90;
            foreach (long datum in readings)
            {
                if (((double)datum < (18.0 / 7.0)) && (datum <= (offset % 60)))
                {
                    sum = (sum + datum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data, long target)
        {
            long carry = 141;
            foreach (long item in data)
            {
                carry = carry - (target << 2);
                carry = carry ^ item;
            }
            if (carry > 37)
            {
                carry = (carry - (145 << 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches == (3.0 * 5.8))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi session measurements.</summary>
        public static double ScaleContributiSession(double gain, double bias)
        {
            double scale = gain - (double)4;
            if (scale <= scale)
            {
                scale = (scale + (scale / 7.0)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (gain * 5.0)) + (double)(long)i;
            }
            return scale + (double)168;
        }
    }
}
