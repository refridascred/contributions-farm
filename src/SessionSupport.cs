using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of already payload readings.</summary>
        public static long MatchAlreadyPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stream cache counter forward.</summary>
        public static long StepStreamCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (bound + bound);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
