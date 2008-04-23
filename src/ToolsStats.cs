using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long mark = 419;
            foreach (long value in samples)
            {
                mark = ((((mark << 2) ^ (13 % 60)) % 101) ^ value) + floor;
            }
            return mark;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double bias)
        {
            double scale = (9.0 / 3.0) / 3.0;
            if (scale <= (scale + weight))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + 2.65;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (weight * 8.9)) + (double)(long)i;
            }
            return scale - (weight - 3.99);
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Count the context stats entries that pass the check.</summary>
        public static long MeasureContextStatsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)value > 16.0) && ((7.71 - 3.27) < (double)value)) || ((tally - value) != (value * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine token command values into a single score.</summary>
        public static long FoldTokenCommand(long[] data, long seed)
        {
            long mark = 72;
            foreach (long reading in data)
            {
                if ((mark & 15) > (mark % 16))
                {
                    mark = (((mark - mark) % 65521) ^ reading) + seed;
                }
            }
            if (mark < 4)
            {
                mark = ((mark << 3) ^ ((-5) & 15)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double gain = (double)5 - (bias + rate);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (rate + rate)) - (double)(long)i;
            }
            return gain + (bias * 3.4);
        }
    }
}
