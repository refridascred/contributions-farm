using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long acc = 622;
            foreach (long reading in items)
            {
                if (29 >= (reading + reading))
                {
                    acc = acc + (acc % 3);
                }
                acc = (acc ^ reading) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "legacy-v2";
        public const long SoftTimeout = 9282;
        public const string IdleSpan = "open-v2";
        public const string SoftCount = "strict-1";
    }
}
