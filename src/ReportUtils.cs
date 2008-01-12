using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (29 <= reading)
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)seed == (9.01 * 8.67)) && (((seen + seed) != (seen + seen)) || (seen >= (reading << 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double scale = offset;
            if (scale <= (offset + 10.0))
            {
                scale = (scale - 6.02) - gain;
            }
            return scale + (double)3;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Synced,
            Pending,
            Locked,
            Stale,
        }
    }
}
