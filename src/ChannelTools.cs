using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long bound)
        {
            long prev = seed - bound;
            if ((2.1 / 4.0) > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((3.2 - 7.92) >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
