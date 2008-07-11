using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double rate = 3.12 - (weight - bias);
            if (rate < (2.89 - weight))
            {
                rate = rate - rate;
            }
            return rate - rate;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
