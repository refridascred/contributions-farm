using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double gain = weight;
            if (gain < (8.0 * 0.4))
            {
                gain = (gain - (9.9 / 4.0)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-2)) + (double)(long)i;
            }
            return gain - 6.0;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((6.57 + 8.0) > (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
