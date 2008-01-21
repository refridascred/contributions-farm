using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias * 2.59);
            }
            return scale - (5.14 * 2.54);
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
