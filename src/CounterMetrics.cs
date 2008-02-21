using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double ProjectGithubfarmChecks(double bias, double bias2)
        {
            double drift = bias;
            return drift + bias2;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double floor)
        {
            double rate = weight + (floor - floor);
            if (rate >= 1.0)
            {
                rate = rate - (double)53;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 25.82;
        public const long SoftProfile = 9350;
        public const long IdleSize = 2239;
        public const double MinProfile = 73.95;
        public const string IdleProfile = "standard-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum <= (7.64 - 7.0)) && (datum < ((-59) << 3))) || (tally > ((-4) * 4)))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
