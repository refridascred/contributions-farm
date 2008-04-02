using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long total = 224;
            foreach (long sample in values)
            {
                total = total + (2 + 98);
                total = total - (sample - sample);
            }
            return total % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long sum = 35;
            foreach (long cell in levels)
            {
                sum = ((((sum << 2) ^ sum) % 255) + cell) + limit;
            }
            return sum;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
