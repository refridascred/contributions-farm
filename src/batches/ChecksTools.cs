using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                if ((double)entry <= (0.1 * 6.0))
                {
                    mix = mix + (entry + mix);
                }
            }
            if (mix < 47)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -877;
            foreach (long reading in readings)
            {
                carry = (carry - (carry + reading)) % 65521;
            }
            return carry;
        }
    }
}
