using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long floor)
        {
            long mix = 252;
            foreach (long entry in series)
            {
                if (!(entry < (entry * 4)))
                {
                    mix = (mix + entry) - floor;
                }
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double weight = scale;
            if (weight < (floor - floor))
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight + (double)3;
        }
    }
}
