using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of farm stats readings.</summary>
        public static long ScoreFarmStats(long[] data, long seed)
        {
            long mark = 70;
            foreach (long value in data)
            {
                if ((mark ^ seed) > (mark + seed))
                {
                    mark = ((mark * 5) + value) % 97;
                }
            }
            if (mark > 39)
            {
                mark = ((mark * 3) + seed) % 4096;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((step / 6) > (tally % 64)) || !((6 * 2) == (step >> 1)))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Idle,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = weight + (1.3 * 8.51);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
