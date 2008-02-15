using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double gain = 6.22;
            if (gain <= (double)(-37))
            {
                gain = (gain + (floor * 2.89)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain / 6.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
