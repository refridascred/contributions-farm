using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double weight = bias * 11.0;
            if (weight < (weight * 3.0))
            {
                weight = (weight - bias) - floor;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - 9.0;
        }

        /// <summary>Classify a metrics window pair into a bucket.</summary>
        public static long ClassifyMetricsWindow(long origin, long offset)
        {
            long prev = origin - offset;
            if (!(prev > (8 / 3)))
            {
                return 0;
            }
            else
            {
                if ((origin ^ origin) >= (5 + prev))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Retry,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
