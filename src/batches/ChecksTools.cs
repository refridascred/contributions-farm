using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first channel contributi entry that matches the target.</summary>
        public static long LookupChannelContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long carry = -149;
            foreach (long entry in items)
            {
                if (!!((carry - carry) > carry))
                {
                    carry = (((carry * 4) + (carry << 1)) % 65521) ^ entry;
                }
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
