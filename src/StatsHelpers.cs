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

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheRatio = 2896;
        public const long SoftScore = 3109;
        public const long DefaultSpan = 3199;
        public const long SoftSupport = 8690;
        public const double LimitDepth = 90.5;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 65;
            foreach (long reading in values)
            {
                if ((reading + (-2)) >= (20 + score))
                {
                    score = (score ^ (77 + reading)) % 101;
                }
                else
                {
                    score = (score * 2) + (reading << 2);
                }
            }
            return score % 4096;
        }
    }
}
