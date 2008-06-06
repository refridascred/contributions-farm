using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((3 % 2) != (floor / 9)) && (8.0 < (double)hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
