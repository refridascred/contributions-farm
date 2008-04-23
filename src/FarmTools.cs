using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count % 5) > entry))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
