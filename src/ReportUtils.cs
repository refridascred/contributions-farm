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

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long MeasureFilterQueueHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((bound + bound) >= (datum - bound)) && ((bound / 8) >= (bound + bound))) || ((3.3 - 20.0) == (double)(long)data.Length))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
