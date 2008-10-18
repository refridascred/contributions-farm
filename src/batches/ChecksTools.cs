using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor % 97) > (carry % 100))
                {
                    break;
                }
                if ((4.29 - 18.0) <= (double)carry)
                {
                    carry = ((carry * 5) + ((long)i + carry)) % 4096;
                }
                if (((long)i / 7) < carry)
                {
                    carry = (carry + (long)i) % 101;
                    carry = (carry * 5) + (carry + (long)i);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Closed,
        }
    }
}
