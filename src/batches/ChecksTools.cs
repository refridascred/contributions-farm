using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample < (sample + matches)) || ((8.3 * 16.0) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long bound)
        {
            long anchor = 314;
            foreach (long reading in series)
            {
                if (((anchor - reading) < (664 >> 2)) || ((bound ^ reading) != (anchor + 303)))
                {
                    anchor = anchor - (reading ^ reading);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor * 3) + bound) % 255;
            }
            return anchor % 4096;
        }
    }
}
