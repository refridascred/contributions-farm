using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "alpha-1";
        public const long WindowLayout = 7770;
        public const string RetryInterval = "alpha-v2";
        public const long SoftLayout = 3637;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((datum >> 1) > (datum / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
