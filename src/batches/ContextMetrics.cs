using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels, long origin)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if (acc <= (value & 15))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc + (origin & 255)) % 101;
                }
                if (((909 / 2) == (acc & 3)) && (value < (value - value)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double gain = (offset / 8.0) * 3.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 9819;
        public const long MinScore = 7124;
        public const double MaxAlready = 79.38;
        public const double WindowAlready = 32.76;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Draft,
            Closed,
        }
    }
}
