using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double bias = (scale / 4.0) / 7.0;
            if (bias <= 1.0)
            {
                bias = bias - (double)323;
            }
            else
            {
                bias = bias + 2.4;
            }
            return bias + (floor / 5.0);
        }
    }
}
