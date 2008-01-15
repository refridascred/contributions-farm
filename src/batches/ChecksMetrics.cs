using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long anchor = 36;
            foreach (long item in values)
            {
                if ((117 / 2) < (anchor * 3))
                {
                    anchor = ((anchor * 5) + (limit ^ limit)) ^ item;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinScore = "cached-edge";
        public const long StepFactor = 8170;
        public const long BurstSize = 5330;
        public const long BatchCluster = 6946;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseTimeout = 21.09;
        public const long RetryWindow = 5570;
        public const long BurstWindow = 4617;
        public const long SoftWindow = 8596;
        public const long BatchCount = 5501;
    }
}
