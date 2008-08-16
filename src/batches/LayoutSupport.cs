using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "legacy-v2";
        public const string StepFactor = "strict-edge";
        public const long RetryStream = 1446;
        public const long DefaultLevel = 8732;
        public const long BatchWidth = 1535;

        /// <summary>Define format limits and defaults.</summary>
        public const double HardDepth = 10.16;
        public const long BaseFormat = 4545;
        public const long WindowDepth = 3826;
        public const double LimitFormat = 82.83;
        public const long BatchFormat = 798;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) >= 78)
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long acc = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc * 4) + (long)i;
                }
                acc = ((acc * 3) + (sample * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Scale a counter route figure with a bias.</summary>
        public static double SmoothCounterRoute(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= ratio)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + 1.65;
        }
    }
}
