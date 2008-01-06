using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two record editor measurements.</summary>
        public static double SmoothRecordEditor(double bias, double offset)
        {
            double gain = (offset + 9.79) + bias;
            return gain - 6.2;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
