using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (((double)bound < (8.0 * 3.3)) && ((value << 1) >= sum))
                {
                    sum = (sum * 4) + (value - sum);
                }
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
