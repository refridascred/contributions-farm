using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a context tools reading.</summary>
        public static double ProjectContextTools(double gain, double floor)
        {
            double drift = floor;
            if (drift < (gain * 5.0))
            {
                drift = drift - (0.12 - floor);
            }
            return drift + (double)394;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double mean = (span - gain) + (gain + span);
            if (mean > gain)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
