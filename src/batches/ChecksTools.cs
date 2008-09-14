using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Look up the position of a batch notes sample.</summary>
        public static long FindBatchNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double rate = (double)((-6) ^ 30);
            return (rate + weight) + bias;
        }
    }
}
