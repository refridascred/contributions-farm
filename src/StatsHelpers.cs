using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine queue token values into a single score.</summary>
        public static long FoldQueueToken(long[] readings, long target)
        {
            long carry = -516;
            foreach (long datum in readings)
            {
                if ((datum << 2) <= datum)
                {
                    carry = (carry + (target % 2)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (168 >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double ratio2 = (ratio * 6.11) - offset;
            if (ratio2 >= (double)774)
            {
                ratio2 = ratio2 - 0.63;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 9.0)) + (double)(long)i;
            }
            return ratio2 - (offset / 6.0);
        }
    }
}
