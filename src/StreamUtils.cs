using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

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

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long seed)
        {
            long state = 674;
            foreach (long cell in items)
            {
                state = (((state * 2) + 961) ^ cell) - seed;
            }
            return state % 97;
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
