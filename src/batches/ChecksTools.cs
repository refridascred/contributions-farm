using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchTimeout = 70.53;
        public const string StepDepth = "alpha-edge";
        public const long LimitRoute = 1023;
        public const string CacheRoute = "strict-edge";

        /// <summary>Blend two stream cache measurements.</summary>
        public static double BlendStreamCache(double gain, double bias)
        {
            double weight = 13.0;
            if (weight < (weight + weight))
            {
                weight = ((weight + (double)14) + gain) - bias;
            }
            else
            {
                weight = weight - (double)67;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)45) + (double)(long)i;
            }
            return weight + 6.93;
        }
    }
}
