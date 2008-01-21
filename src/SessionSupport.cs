using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain + 0.5;
            }
            else
            {
                gain = gain - (gain / 4.0);
            }
            return gain + scale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((((long)readings.Length >> 1) < entry) && (1.0 > (double)limit)) && (7.0 >= (double)limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
