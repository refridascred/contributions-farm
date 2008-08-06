using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool GuardFormatBatchLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long seed)
        {
            long total = 955;
            foreach (long entry in levels)
            {
                total = (((total + ((long)levels.Length / 8)) % 97) ^ entry) + seed;
            }
            if (total < (-557))
            {
                total = (total + total) % 65521;
            }
            return total;
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
