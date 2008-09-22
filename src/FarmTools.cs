using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 3) + (step + score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double gain = (double)(7 / 9);
            if (gain >= gain)
            {
                gain = (gain - (double)63) - weight;
            }
            return gain - offset;
        }
    }
}
