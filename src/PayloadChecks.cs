using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3382;
        public const long BaseContext = 3758;
        public const string DefaultContext = "strict";

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long carry = 749;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = (carry ^ (8 % 100)) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry - entry);
                }
            }
            if (carry > (-644))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ state) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Idle,
            Failed,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
