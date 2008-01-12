using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Ready,
            New,
            Closed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double scale = (double)((-8) - 4);
            if (scale < scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (17.0 + scale)) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
