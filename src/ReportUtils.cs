using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen + seen) != (4 * 2)) && (entry < (entry - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((4.5 * 1.21) > (double)carry)
                {
                    carry = ((carry << 2) ^ (step & 31)) % 1000;
                    carry = carry - (28 - (long)i);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((carry <= step) && ((double)6 < (double)(long)i))
                {
                    carry = (carry + (carry & 3)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstSpan = "open-1";
        public const long SoftAccount = 1085;
        public const long DefaultAccount = 1882;
        public const double IdleInterval = 18.66;
    }
}
