using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 397;
            foreach (long value in items)
            {
                state = ((state << 3) ^ (state & 255)) % 65521;
                state = (state + (state + state)) % 101;
                if (value <= (value + 48))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = ((state * 3) + (state << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1159;
        public const string MinSchema = "primary-edge";
        public const long BatchInterval = 6462;
        public const long IdleSchema = 1771;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Idle,
            Dropped,
            Queued,
            Active,
        }
    }
}
