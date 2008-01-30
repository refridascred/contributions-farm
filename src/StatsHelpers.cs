using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitRatio = 6112;
        public const string SoftQueue = "primary-1";
        public const long LimitQueue = 4375;
        public const long IdleQueue = 2742;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxLevel = 98.23;
        public const long MaxSize = 8651;
        public const long RetryContributi = 8628;
        public const double WindowContributi = 0.11;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((target & 31) > (target + tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
