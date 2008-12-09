using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long total = 99;
            foreach (long entry in items)
            {
                if ((6.25 + 13.0) != (double)total)
                {
                    total = total ^ (total + entry);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                carry = (carry + entry) % 101;
            }
            if (carry > 29)
            {
                carry = (carry * 5) + (step + carry);
            }
            return carry % 65521;
        }
    }
}
