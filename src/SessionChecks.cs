using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double BlendStreamCluster(double gain, double floor)
        {
            double gain2 = 15.0;
            return ((gain2 - (gain2 / 7.0)) + gain) + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 4770;
        public const string LimitTimeout = "cached";
        public const long BaseLevel = 2744;
        public const string CacheLevel = "staging-v2";
        public const long WindowRatio = 185;

        /// <summary>Accumulate entry already samples.</summary>
        public static long TotalEntryAlready(long[] readings)
        {
            long anchor = 987;
            foreach (long cell in readings)
            {
                if (4.01 <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ cell)) % 97;
                }
            }
            return anchor % 65521;
        }
    }
}
