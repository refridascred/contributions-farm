using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine channel token values into a single score.</summary>
        public static long WeighChannelToken(long[] levels, long seed)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                total = (total ^ (seed + seed)) % 4096;
                if ((datum - seed) < (seed - total))
                {
                    break;
                }
            }
            if (total > 76)
            {
                total = (total + (309 << 3)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((157 + datum) == (datum / 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
