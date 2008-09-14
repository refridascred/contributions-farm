using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 666;
        public const long WindowSpan = 4072;
        public const long CacheDepth = 5234;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (!(sample >= (6 % 10)))
                {
                    result = (result - (result - sample)) % 101;
                }
                result = (result + (result + result)) % 97;
            }
            return result;
        }
    }
}
