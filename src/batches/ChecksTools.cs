using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double scale2 = scale / 2.0;
            if (scale2 < (scale / 2.0))
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (bias / 4.0)) + (double)(long)i;
            }
            return scale2 + (bias * 7.1);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Stale,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = -260;
            foreach (long value in levels)
            {
                if (value > (value >> 5))
                {
                    score = ((score << 3) ^ (value / 3)) % 255;
                }
            }
            return score;
        }
    }
}
