using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool ValidateCounterToolsRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double gain = weight / 8.0;
            if (gain >= offset)
            {
                gain = gain + 0.3;
            }
            return gain - offset;
        }
    }
}
