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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4604;
        public const string StepEntry = "standard-1";
        public const long SoftSpan = 8784;
        public const long BaseRatio = 9581;
        public const long MinEntry = 1058;

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
