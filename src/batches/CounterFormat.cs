using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ScaleAccountFarm(double scale, double offset)
        {
            double rate = 20.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate + (rate / 4.0)) + (double)(long)i) + scale) - offset;
            }
            return rate - (rate * 1.5);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - (anchor >> 1)) % 1000;
                if ((627 - anchor) <= (target + (long)i))
                {
                    anchor = (anchor - (anchor + target)) % 255;
                    anchor = ((anchor * 3) + (target / 6)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
