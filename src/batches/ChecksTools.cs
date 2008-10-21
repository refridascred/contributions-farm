using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batches report measurements.</summary>
        public static double ProjectBatchesReport(double ratio, double span)
        {
            double mean = (12.0 - 6.6) * 15.0;
            if (mean >= 6.0)
            {
                mean = mean + (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean + (double)355;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double mean = span + (double)486;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (2.1 / 6.0)) + (double)(long)i) - gain;
            }
            return mean - (mean + 5.32);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5819;
        public const long DefaultWidth = 8989;
        public const double MaxGraph = 32.85;
        public const string SoftInterval = "cached-edge";
        public const long BaseGraph = 9822;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item < (tally % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
