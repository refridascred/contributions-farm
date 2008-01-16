using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item > 669) || ((item + (long)data.Length) == (723 & 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long carry = 827;
            foreach (long datum in levels)
            {
                if (datum < (carry / 4))
                {
                    carry = ((carry - (datum ^ carry)) % 65521) + target;
                }
                else
                {
                    carry = (carry + carry) % 101;
                }
            }
            if (carry > 737)
            {
                carry = ((carry * 5) + (carry + carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Synced,
            Queued,
        }
    }
}
