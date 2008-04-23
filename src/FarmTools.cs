using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] items)
        {
            long result = 803;
            foreach (long sample in items)
            {
                if (!(((double)sample <= (double)result) && ((double)result == (double)sample)))
                {
                    result = result ^ (result + 7);
                }
                if (((result % 3) < (sample >> 4)) && ((sample - 9) <= (sample - result)))
                {
                    result = result - result;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double span)
        {
            double drift = (double)(37 + 17);
            if (drift <= (drift - ratio))
            {
                drift = (drift + ratio) - span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift + (drift + drift);
        }
    }
}
