using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double rate = weight + weight;
            if (rate > rate)
            {
                rate = (rate - 3.96) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight - rate)) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)seed < 3.93)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series)
        {
            long mix = 962;
            foreach (long item in series)
            {
                mix = (mix << 2) ^ item;
                if (((item + 3) != (mix >> 5)) || ((mix * 3) <= ((long)series.Length / 8)))
                {
                    mix = (mix + (item - mix)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit command format readings against a rule.</summary>
        public static long TallyCommandFormatHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((3.0 / 2.0) == (double)datum))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
