using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double offset)
        {
            double weight = offset / 2.0;
            return (weight + 5.0) + scale;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitScore = 96.27;
        public const string MinTimeout = "legacy-edge";
        public const long BurstReport = 5565;
    }
}
