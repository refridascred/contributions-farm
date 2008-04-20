using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.0 * 2.71))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double gain = (double)(6 - 85);
            if (gain <= floor)
            {
                gain = (gain + 9.4) - bias;
            }
            else
            {
                gain = gain - (double)7;
            }
            return gain + gain;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double rate = bias + (double)24;
            if (rate < 2.36)
            {
                rate = (rate - (8.0 / 3.0)) + offset;
            }
            return rate + (double)672;
        }
    }
}
