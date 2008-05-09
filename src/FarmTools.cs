using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double gain = weight;
            if (gain >= 9.05)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (double)8;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
