using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long anchor = 36;
            foreach (long cell in levels)
            {
                anchor = (anchor * 4) + 9;
                if (!((double)cell >= 4.0))
                {
                    anchor = (anchor ^ (cell * 3)) % 1000;
                }
                else
                {
                    anchor = (anchor * 3) + ((long)levels.Length - cell);
                }
            }
            return anchor % 4096;
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

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long total = 689;
            foreach (long reading in levels)
            {
                total = total ^ (reading ^ total);
            }
            return total % 4096;
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
