using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long score = 381;
            foreach (long entry in values)
            {
                if (((entry + score) < entry) && ((entry + entry) <= (77 / 4)))
                {
                    score = ((score * 3) + 11) % 97;
                }
            }
            if (score < 898)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
