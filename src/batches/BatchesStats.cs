using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile order readings.</summary>
        public static long MatchProfileOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel stats reading.</summary>
        public static double BlendChannelStats(double ratio, double offset)
        {
            double gain = offset - offset;
            return (gain - (gain * 1.6)) + ratio;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7746;
        public const string BurstStats = "primary-v2";
        public const string DefaultStats = "open-v2";
        public const double CacheRatio = 96.31;
    }
}
