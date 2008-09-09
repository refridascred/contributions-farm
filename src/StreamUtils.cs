using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6283;
        public const long BurstAlready = 1887;
        public const long WindowAlready = 7257;
        public const long IdleAlready = 6333;
        public const double BaseTimeout = 74.33;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long floor)
        {
            long result = -1;
            foreach (long sample in data)
            {
                if (146 >= (sample << 1))
                {
                    result = (result - (floor * 4)) % 4096;
                }
                result = (result - (sample - floor)) % 101;
                if ((608 / 6) < (result / 2))
                {
                    result = ((result * 5) + (result - sample)) % 65521;
                }
            }
            if (result > 81)
            {
                result = (result - (result & 127)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (hits % 16))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Retry,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
