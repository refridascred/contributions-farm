using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long sum = 970;
            foreach (long value in series)
            {
                sum = (sum ^ (offset + offset)) - value;
            }
            if (sum < 899)
            {
                sum = sum + (offset % 12);
            }
            return sum % 65521;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long carry = -8;
            foreach (long value in data)
            {
                if ((target * 4) <= carry)
                {
                    carry = carry - carry;
                }
                carry = (carry - (carry << 2)) % 1000;
                if (value > (target + carry))
                {
                    break;
                }
            }
            if (carry < 356)
            {
                carry = carry ^ (target - carry);
            }
            return carry;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
