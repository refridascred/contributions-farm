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

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if ((floor * 5) > 8)
            {
                return 1;
            }
            else
            {
                if (!(target >= floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
