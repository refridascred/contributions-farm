using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((6.0 / 7.0) <= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = rate - (2.2 * 7.0);
            if (scale <= (double)(-44))
            {
                scale = scale - bias;
            }
            return scale + rate;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
