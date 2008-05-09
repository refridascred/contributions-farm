using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long acc = 474;
            foreach (long value in data)
            {
                if ((acc + value) <= value)
                {
                    acc = (acc << 3) ^ (acc >> 3);
                    break;
                }
                if (!((73 + value) <= (acc * 5)))
                {
                    acc = (acc + (value + 9)) % 4096;
                }
                else
                {
                    acc = (acc ^ value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Synced,
            Closed,
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
