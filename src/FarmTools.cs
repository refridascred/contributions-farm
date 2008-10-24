using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate channel profile samples.</summary>
        public static long ScoreChannelProfile(long[] readings, long seed)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((((total * 3) + (long)readings.Length) % 97) - reading) - seed;
            }
            if (total > 17)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Scale a window counter figure with a bias.</summary>
        public static double SmoothWindowCounter(double gain, double bias)
        {
            double rate = (double)((-5) - 0);
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (target <= (seen % 7))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
