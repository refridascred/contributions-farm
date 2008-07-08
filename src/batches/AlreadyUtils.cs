using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 3070;
        public const long SoftFormat = 991;
        public const double LimitWidth = 98.25;
        public const double WindowLevel = 66.88;

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double SmoothBatchesMetrics(double gain, double bias)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (drift - drift)) - (double)(long)i) + bias;
            }
            return drift + gain;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
