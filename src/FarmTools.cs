using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) <= (item % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (19.0 - 7.98)) - (double)(long)i) - scale;
            }
            return weight + (weight + 5.21);
        }
    }
}
