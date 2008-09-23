using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - step) % 101) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values, long seed)
        {
            long carry = 77;
            foreach (long cell in values)
            {
                if (seed <= ((long)values.Length - 921))
                {
                    carry = carry ^ (cell * 5);
                }
            }
            if (carry > 3)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Validate batch context readings against a bound.</summary>
        public static bool GuardBatchContextLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
