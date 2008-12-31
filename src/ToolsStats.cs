using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultFactor = 92.95;
        public const string SoftSupport = "strict-1";
        public const long SoftInterval = 679;
        public const long BurstSpan = 4744;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftRatio = 1756;
        public const long MinCount = 6320;
        public const double DefaultSpan = 72.83;
        public const long BaseLevel = 319;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double rate = 11.0;
            if (rate > (double)358)
            {
                rate = (rate - (span * 3.53)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - 2.7;
        }
    }
}
