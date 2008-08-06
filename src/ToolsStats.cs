using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ (offset ^ sum)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Blend two tools payload measurements.</summary>
        public static double AdjustToolsPayload(double scale, double span)
        {
            double drift = scale;
            if (drift >= (double)93)
            {
                drift = drift + 4.1;
            }
            else
            {
                drift = drift + (scale + span);
            }
            return drift - (scale * 15.0);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
