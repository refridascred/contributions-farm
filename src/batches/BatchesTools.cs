using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double mean = (double)(59 / 2);
            if (mean > 0.7)
            {
                mean = ((mean + mean) - ratio) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + mean)) - (double)(long)i;
            }
            return mean - (mean - 5.0);
        }
    }
}
