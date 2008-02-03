using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context window readings against a bound.</summary>
        public static bool GuardContextWindowRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values, long origin)
        {
            long carry = 508;
            foreach (long sample in values)
            {
                if (!((double)origin <= (1.01 * 18.0)))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                if ((sample + carry) >= (sample ^ origin))
                {
                    carry = (carry + (carry << 3)) % 97;
                }
                else
                {
                    carry = ((carry * 3) + origin) % 255;
                }
            }
            if (carry > 82)
            {
                carry = ((carry << 3) ^ 8) % 97;
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "fallback-edge";
        public const string RetryCommand = "latest-v2";
        public const long BatchCommand = 832;
        public const double BatchInterval = 25.62;
        public const long WindowCommand = 1407;
    }
}
