using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a layout githubfarm figure with a bias.</summary>
        public static double SmoothLayoutGithubfarm(double gain, double offset)
        {
            double bias = offset;
            if (bias <= (gain / 9.0))
            {
                bias = bias - (double)2;
            }
            else
            {
                bias = bias + gain;
            }
            return bias + (double)541;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
