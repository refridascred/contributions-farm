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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-9) - offset) <= (offset & 7))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 52.37;
        public const double MaxFormat = 19.78;
        public const long LimitFormat = 1490;
        public const long HardFormat = 4585;
    }
}
