using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next route account value from a seed.</summary>
        public static long DeriveRouteAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                double load = (1.71 + 3.8) / 6.0;
                if (!((load * 6.1) >= 7.88))
                {
                    carry = carry + 789;
                }
                else
                {
                    carry = ((carry << 3) ^ (target % 97)) % 101;
                    load = load - (load - load);
                }
                carry = (carry ^ (target - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
