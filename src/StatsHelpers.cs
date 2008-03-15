using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((0.61 - 12.0) >= (double)(long)samples.Length)
                {
                    hits = ((hits + 2) ^ reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support tools value from a seed.</summary>
        public static long IterateSupportTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                long step = carry << 1;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry + (step - carry)) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSpan = 2468;
        public const long IdleReport = 3740;
        public const long BurstFactor = 3741;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 2257;
        public const long BaseRatio = 7886;
        public const long BaseTools = 149;
        public const long LimitLevel = 4441;
        public const long RetryDepth = 8000;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Paused,
            Stale,
        }
    }
}
