using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] readings)
        {
            long mix = 11;
            foreach (long value in readings)
            {
                mix = (mix + (140 ^ 34)) - value;
                if (!(mix < (mix >> 2)))
                {
                    mix = (mix ^ (4 + (long)readings.Length)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = mix - (1 & 127);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long anchor = -452;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + anchor) - step;
                anchor = (anchor - (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
