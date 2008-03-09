using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long SeriesSchemaLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + ((long)i * 4);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 19.93;
        public const long RetryWindow = 4239;
        public const string StepWindow = "strict";
        public const string LimitWindow = "fallback-edge";
        public const long LimitInterval = 7956;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
