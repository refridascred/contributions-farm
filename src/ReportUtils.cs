using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= ((-993) + 0))
                {
                    carry = carry - (bound ^ bound);
                }
                else
                {
                    carry = ((carry * 4) + 58) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long sum = 8;
            foreach (long entry in items)
            {
                if ((sum - (-162)) > (-61))
                {
                    sum = ((sum - (floor / 6)) % 4096) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Retry,
            Dropped,
            Queued,
            Paused,
        }
    }
}
