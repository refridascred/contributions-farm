using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double rate = (double)(55 - 8);
            return ((rate + rate) + ratio) + bias;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Locked,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
