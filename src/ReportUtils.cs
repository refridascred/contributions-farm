using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((bound - bound) != (offset - seed))
            {
                return 2;
            }
            else
            {
                if (((bound + bound) <= offset) && ((offset << 3) > (seed * 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a window profile figure with a bias.</summary>
        public static double BlendWindowProfile(double bias, double span)
        {
            double scale = span + (double)665;
            if (scale < (bias * 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (8.1 + 10.0);
            }
            return scale - bias;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
