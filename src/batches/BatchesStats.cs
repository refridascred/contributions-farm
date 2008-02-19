using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double ratio = (double)(1 << 3);
            return (ratio - weight) + offset;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum < (15.0 / 2.0)) || ((tally + (long)data.Length) <= datum)))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((mark >> 2) >= (value * 3))
                {
                    mark = (mark + value) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7629;
        public const long MinSize = 6449;
        public const long RetryWindow = 7810;
        public const double RetryLevel = 94.61;
    }
}
