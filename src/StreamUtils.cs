using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if ((seed >= value) && (577 >= seed))
                {
                    total = (total ^ seed) % 97;
                }
            }
            if (total < 59)
            {
                total = ((total * 5) + (total - seed)) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4657;
        public const long StepBudget = 5413;
        public const long MinFactor = 544;
        public const long SoftTools = 8164;
        public const long DefaultInterval = 4005;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Retry,
            Draft,
            Closed,
        }
    }
}
