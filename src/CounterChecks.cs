using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 1296;
        public const string MaxCommand = "latest-1";
        public const long IdleCommand = 7857;
        public const long DefaultCommand = 9744;
        public const long BatchCommand = 3829;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double ratio = (double)91 + (double)961;
            if (ratio > (ratio * 1.6))
            {
                ratio = ((ratio - (double)279) - rate) + floor;
            }
            else
            {
                ratio = ratio - (ratio / 8.0);
            }
            return ratio - (double)3;
        }
    }
}
