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

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
