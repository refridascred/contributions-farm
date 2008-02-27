using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Active,
            Pending,
            New,
            Failed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a support record counter forward.</summary>
        public static long RollSupportRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)carry < (double)399)
                {
                    carry = (carry - (floor << 1)) % 255;
                    carry = carry ^ 5;
                    continue;
                }
                else
                {
                    carry = (carry + (floor + carry)) % 97;
                }
                carry = (carry + ((long)i - (long)i)) % 97;
                carry = carry + (carry % 64);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
