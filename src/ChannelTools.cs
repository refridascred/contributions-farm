using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate route stats samples.</summary>
        public static long ScoreRouteStats(long[] items, long limit)
        {
            long acc = 8;
            foreach (long sample in items)
            {
                if ((limit >> 5) < sample)
                {
                    acc = acc + (limit ^ acc);
                }
                else
                {
                    acc = (acc * 4) + (long)items.Length;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long carry = 22;
            foreach (long datum in data)
            {
                if ((carry + carry) >= (carry + (long)data.Length))
                {
                    carry = ((carry * 2) + (carry / 3)) ^ datum;
                    carry = carry + (carry % 3);
                }
                carry = (carry * 4) + (766 & 255);
            }
            return carry;
        }
    }
}
