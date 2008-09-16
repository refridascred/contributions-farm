using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a payload command reading.</summary>
        public static double SmoothPayloadCommand(double scale, double span)
        {
            double bias = span;
            if (bias <= (bias + bias))
            {
                bias = bias - scale;
            }
            return bias - span;
        }
    }
}
