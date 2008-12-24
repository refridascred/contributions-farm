using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = (bias + 5.0) / 2.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - offset;
            }
            return rate + rate;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
