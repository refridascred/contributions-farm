using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)seed < (2.3 - 2.53)) || ((value ^ seed) == ((long)levels.Length * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entry entries.</summary>
        public static long FoldProfileEntry(long[] items)
        {
            long mix = 147;
            foreach (long value in items)
            {
                if (mix < (value + value))
                {
                    mix = (mix ^ (value << 3)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (value ^ mix);
                }
            }
            if (mix > 334)
            {
                mix = (mix + (mix - 2)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double scale = rate;
            if (scale < (scale - rate))
            {
                scale = scale - (span - rate);
            }
            else
            {
                scale = scale + scale;
            }
            return scale + 14.0;
        }
    }
}
