using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long carry = 8;
            foreach (long sample in values)
            {
                carry = (((carry * 5) + (target + carry)) % 1000) ^ sample;
                carry = (carry << 2) ^ (target / 2);
            }
            return carry % 1000;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Queued,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = offset;
            return bias - (scale * 6.73);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
