using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 19.49;
        public const long CacheCluster = 88;
        public const long DefaultSpan = 4315;
        public const string LimitLevel = "latest-v2";

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 3159;
        public const long BatchSession = 7791;
        public const long WindowSession = 6541;
        public const string BurstSession = "primary";
        public const string MinLevel = "cached-1";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
