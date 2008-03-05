using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (limit + state)) % 101;
                if (state <= (limit - 107))
                {
                    state = ((state * 3) + state) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine cluster command values into a single score.</summary>
        public static long WeighClusterCommand(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                carry = (carry + (value << 3)) % 255;
                if (value < (carry - carry))
                {
                    carry = (carry * 4) + (394 * 3);
                }
                else
                {
                    carry = carry + (value + value);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series)
        {
            long carry = 494;
            foreach (long sample in series)
            {
                if ((415 - sample) >= (carry & 255))
                {
                    carry = (carry - (carry >> 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }
    }
}
