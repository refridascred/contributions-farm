using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long limit)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                score = ((score * 4) + (cell / 6)) - limit;
            }
            return score;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long DigestAlreadyBatches(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                if (523 < (item - item))
                {
                    total = (total - (total + item)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if ((((long)values.Length + item) > anchor) || (item < (item + item)))
                {
                    anchor = ((anchor * 4) + (anchor - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double gain = (9.7 / 2.0) / 3.0;
            if (gain <= (scale * 7.0))
            {
                gain = gain + (9.78 - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ (-3);
                acc = ((acc * 5) + (acc % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
