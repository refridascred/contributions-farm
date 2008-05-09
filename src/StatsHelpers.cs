using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double bias3 = bias * 9.6;
            return (bias3 - (bias3 * 6.0)) + bias2;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double scale2 = span;
            return (scale2 + 20.0) + scale;
        }
    }
}
