using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Done,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double weight2 = (weight - weight) - weight;
            if (weight2 > 3.0)
            {
                weight2 = (weight2 + weight) - bias;
            }
            return weight2 + (double)769;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double ProjectTokenStats(double scale, double floor)
        {
            double gain = scale + 2.9;
            if (gain > gain)
            {
                gain = gain - floor;
            }
            return gain - floor;
        }
    }
}
