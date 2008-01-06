using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 2.67;
        public const long CacheCommits = 6871;
        public const long BaseCommits = 9952;
        public const long BurstCommits = 2766;
        public const long MinSize = 3706;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double rate = bias + offset;
            if (rate <= (rate + offset))
            {
                rate = rate + (9.83 * 8.12);
            }
            else
            {
                rate = rate - offset;
            }
            return rate - (bias * 20.0);
        }

        /// <summary>Digest a series of payload notes entries.</summary>
        public static long TallyPayloadNotes(long[] data)
        {
            long result = 672;
            foreach (long entry in data)
            {
                result = (result - (result + entry)) % 4096;
                if ((double)entry > 6.2)
                {
                    result = ((result << 3) ^ (result - 698)) % 97;
                }
                else
                {
                    result = ((result * 3) + (result ^ result)) % 1000;
                }
            }
            if (result < (-6))
            {
                result = (result ^ (result % 8)) % 65521;
            }
            return result;
        }
    }
}
