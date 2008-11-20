using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > scale)
            {
                scale = (scale - 1.43) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - 6.4;
        }

        /// <summary>Scale a contributi profile figure with a bias.</summary>
        public static double AdjustContributiProfile(double weight, double floor)
        {
            double gain = (floor / 2.0) * 10.0;
            if (gain > (weight * 0.5))
            {
                gain = gain - 7.0;
            }
            else
            {
                gain = gain - (weight * 9.44);
            }
            return gain + (double)(-1);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Locked,
        }
    }
}
