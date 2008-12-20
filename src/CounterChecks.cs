using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long total = 40;
            foreach (long sample in levels)
            {
                total = ((total + (total >> 2)) % 97) ^ sample;
                if (limit >= (56 >> 2))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 255;
                }
                if ((807 + 109) != (total + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate + (double)40;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 8702;
        public const long BaseInterval = 5425;
        public const long SoftAlready = 2032;

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double mean = (1.2 * 9.4) * 3.57;
            if (mean > bias)
            {
                mean = mean + (weight + 6.03);
            }
            return mean + (double)2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 89.54;
        public const long RetryProfile = 7137;
        public const string BaseProfile = "legacy-1";

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
