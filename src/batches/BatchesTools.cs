using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double mean = 1.7 * 2.32;
            if (mean < (double)31)
            {
                mean = (mean + (mean - 2.0)) - gain;
            }
            return mean - span;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
