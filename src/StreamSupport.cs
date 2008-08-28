using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix * 4) + (mix + seed);
                mix = (mix - (seed * 4)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double mean = gain;
            if (mean < (offset + 3.0))
            {
                mean = mean - (gain - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (gain / 5.0);
        }
    }
}
