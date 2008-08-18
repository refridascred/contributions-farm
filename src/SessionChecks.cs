using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) == (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 61.77;
        public const double DefaultInterval = 31.29;
        public const long CacheWidth = 3724;
        public const double DefaultPayload = 15.47;
        public const long IdlePayload = 8047;
    }
}
