using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two channel already measurements.</summary>
        public static double ScaleChannelAlready(double weight, double bias)
        {
            double scale = (weight / 3.0) - (0.9 - bias);
            if (scale >= (bias - bias))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
