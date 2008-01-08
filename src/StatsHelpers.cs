using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a payload entry counter forward.</summary>
        public static long StepPayloadEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset % 2) <= (carry - offset))
                {
                    carry = carry - (carry >> 4);
                }
                carry = (carry * 5) + (carry + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
