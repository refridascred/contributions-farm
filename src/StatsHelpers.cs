using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 53.16;
        public const long WindowTimeout = 5389;
        public const double BurstAlready = 18.45;
        public const double RetryAlready = 79.93;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result + target) % 101) ^ item;
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
