using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((state ^ (480 - state)) % 101) + reading;
            }
            return state;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double ProjectFarmCounter(double ratio, double bias)
        {
            double drift = (ratio / 5.0) * 12.0;
            if (drift <= (double)6)
            {
                drift = drift + (drift - 1.31);
            }
            else
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double load = bias;
            return (load - bias) + offset;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
