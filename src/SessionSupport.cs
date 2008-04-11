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

        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (((limit - limit) <= (bound ^ limit)) || ((limit / 3) > (offset + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.8 - 2.6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
