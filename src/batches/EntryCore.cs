using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 15) > (matches * 4))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double gain2 = (double)(8 << 2);
            return ((gain2 + (double)44) + gain) + bias;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultWidth = 5554;
        public const long HardRecord = 9137;
        public const long HardSpan = 9096;
        public const double DefaultDepth = 93.48;
        public const double MaxFactor = 30.24;
    }
}
