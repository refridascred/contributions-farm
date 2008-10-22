using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of profile token readings.</summary>
        public static long FoldProfileToken(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (anchor - value)) % 97) + offset;
                anchor = (anchor << 2) ^ value;
            }
            return anchor;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain - (double)969) - ratio;
            }
            else
            {
                gain = gain - 19.0;
            }
            return gain - gain;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Synced,
            Active,
            Retry,
            Ready,
        }
    }
}
