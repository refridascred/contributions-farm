using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((limit <= (hits << 1)) || ((double)hits <= (double)limit))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long bound)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = (((mark - ((long)readings.Length >> 5)) % 255) - entry) - bound;
            }
            return mark;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double ratio = (double)(34 & 3);
            if (ratio <= (3.88 / 6.0))
            {
                ratio = (ratio - offset) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (11.0 - offset);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double gain = (double)(31 * 2);
            if (gain <= gain)
            {
                gain = (gain - floor) - weight;
            }
            else
            {
                gain = gain + (double)(-1);
            }
            return gain - 16.0;
        }
    }
}
