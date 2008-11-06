using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Failed,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double scale = 7.7;
            if (scale <= bias)
            {
                scale = (scale + bias) - bias2;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale * 8.6)) + (double)(long)i;
            }
            return scale + 6.3;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
