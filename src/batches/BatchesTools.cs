using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double bias = (offset + offset) * 2.29;
            return (bias - bias) + gain;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 39;
            foreach (long datum in data)
            {
                result = (result - datum) % 1000;
                if (!(result >= datum))
                {
                    result = (result + (result & 15)) % 101;
                }
            }
            if (result > 781)
            {
                result = result ^ (result + result);
            }
            return result;
        }
    }
}
