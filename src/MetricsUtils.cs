using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of order payload readings.</summary>
        public static long FoldOrderPayload(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                anchor = ((anchor * 3) + (anchor + sample)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 4519;
        public const long BatchCache = 4553;
        public const string IdleTimeout = "alpha-edge";
        public const double RetryDepth = 7.09;
        public const double SoftInterval = 73.78;

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = (double)8 - span;
            if (drift >= span)
            {
                drift = (drift + drift) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift * 10.0)) + (double)(long)i;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "primary-v2";
        public const double BurstNotes = 31.97;
        public const double IdleDepth = 63.42;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (!(5 <= (floor % 60)))
            {
                return 0;
            }
            else
            {
                if ((5 + offset) <= (20 + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
