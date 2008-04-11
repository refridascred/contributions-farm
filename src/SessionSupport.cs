using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long CountProfileOrderMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound + 564) < (bound / 3))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long carry = 24;
            foreach (long sample in readings)
            {
                if (((-9) ^ sample) > (sample + 7))
                {
                    carry = carry + (sample >> 5);
                }
            }
            return carry;
        }
    }
}
