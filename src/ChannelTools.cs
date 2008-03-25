using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool GuardGithubfarmBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8254;
        public const long StepLevel = 7212;
        public const long SoftDepth = 2930;
        public const long BurstLayout = 3489;
        public const string SoftTimeout = "alpha-1";

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double scale = (9.49 * 3.0) / 3.0;
            if (scale <= floor)
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + rate)) - (double)(long)i;
            }
            return scale + floor;
        }
    }
}
