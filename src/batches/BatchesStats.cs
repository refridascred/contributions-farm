using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two account queue measurements.</summary>
        public static double ProjectAccountQueue(double ratio, double offset)
        {
            double ratio2 = (17.0 * 4.8) * 9.8;
            if (ratio2 <= (double)0)
            {
                ratio2 = ratio2 + (ratio / 9.0);
            }
            else
            {
                ratio2 = ratio2 + (offset / 3.0);
            }
            return ratio2 + (6.91 + ratio);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 8959;
        public const long StepProfile = 2300;
        public const string DefaultScore = "standard-edge";
        public const long BurstLevel = 2376;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Locked,
            Draft,
            Done,
        }
    }
}
