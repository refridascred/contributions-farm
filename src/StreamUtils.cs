using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySize = 2008;
        public const double WindowBuffer = 43.92;
        public const string StepDepth = "staging-v2";

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 45;
            foreach (long cell in levels)
            {
                if (((cell / 3) != (cell + cell)) || ((mark & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (19 + 5)) % 255;
                }
                if ((mark - cell) <= 563)
                {
                    mark = mark - 40;
                }
            }
            return mark;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long TallyPayloadRecord(long[] items)
        {
            long mark = 44;
            foreach (long sample in items)
            {
                mark = (mark * 2) + (sample + mark);
            }
            return mark;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double span)
        {
            double load = span;
            if (load < (weight / 7.0))
            {
                load = load + span;
            }
            return load + (double)989;
        }
    }
}
