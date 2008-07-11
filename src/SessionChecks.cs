using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] samples, long bound)
        {
            long carry = 51;
            foreach (long value in samples)
            {
                carry = (carry - (value * 2)) + bound;
            }
            if (carry > 1)
            {
                carry = carry - ((long)samples.Length / 8);
            }
            return carry;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + ((long)i * 5)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "strict-edge";
        public const double RetryRatio = 64.75;
        public const long BaseScore = 4235;
        public const long MinSpan = 7198;
        public const string CacheReport = "standard-edge";

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
