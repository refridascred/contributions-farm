using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double scale = 15.0;
            if (scale <= (scale + offset))
            {
                scale = (scale - 18.0) + gain;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (offset / 8.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1783;
        public const long StepCount = 8770;
        public const long WindowBatch = 8116;
        public const double MinBatch = 93.49;
    }
}
