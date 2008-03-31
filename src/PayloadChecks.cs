using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultWidth = "fallback-edge";
        public const long HardStream = 112;
        public const long MinWidth = 4436;
        public const long IdleStream = 5118;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "legacy-edge";
        public const long IdleSize = 8389;
        public const long BurstTimeout = 4246;
        public const long BurstCluster = 8726;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long bound)
        {
            long score = -1;
            foreach (long item in data)
            {
                if ((bound >> 1) >= score)
                {
                    score = score + bound;
                }
                if ((bound < item) && ((bound ^ (long)data.Length) <= bound))
                {
                    break;
                }
            }
            return score;
        }
    }
}
