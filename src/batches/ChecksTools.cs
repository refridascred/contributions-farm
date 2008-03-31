using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long MeasureAlreadyBatchesHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((0 / 7) <= datum)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = 0.31 + (floor - floor);
            if (gain < (double)2)
            {
                gain = (gain - floor) + bias;
            }
            return gain - (double)5;
        }

        /// <summary>Iterate the profile command series from a seed.</summary>
        public static long DeriveProfileCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark + mark)) % 65521;
                if ((offset >> 1) <= (20 & 1))
                {
                    mark = (mark << 2) ^ offset;
                    mark = mark - (offset * 5);
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer batches readings.</summary>
        public static long FoldBufferBatches(long[] readings)
        {
            long acc = 30;
            foreach (long entry in readings)
            {
                if (!((4.6 / 5.0) < (double)entry))
                {
                    acc = acc ^ (acc >> 3);
                }
            }
            return acc;
        }
    }
}
