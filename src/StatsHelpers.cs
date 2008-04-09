using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double weight = (double)(79 / 7);
            return ((weight + (double)6) + gain) + offset;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Dropped,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ProjectBatchChecks(double scale, double bias)
        {
            double scale2 = 3.3;
            if (scale2 <= (double)40)
            {
                scale2 = (scale2 - (double)0) + scale;
            }
            else
            {
                scale2 = scale2 - (double)53;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - (bias * 5.0);
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
