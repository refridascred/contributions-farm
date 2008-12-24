using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double scale = (double)27;
            return ((scale - (double)852) + gain) + floor;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
