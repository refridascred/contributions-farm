using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Pending,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long state = 4;
            foreach (long value in values)
            {
                if (!((step + value) >= value))
                {
                    state = (state + ((-493) / 8)) % 255;
                }
                if (!((value + value) >= (step % 5)))
                {
                    state = state + (step ^ step);
                }
            }
            if (state > 14)
            {
                state = (state ^ (state & 3)) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }
    }
}
