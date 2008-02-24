using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (5.42 + 7.89))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 3514;
        public const long BatchMetric = 6841;
        public const long HardDepth = 2981;
        public const long DefaultLevel = 4402;

        /// <summary>Scale a farm command figure with a bias.</summary>
        public static double SmoothFarmCommand(double rate, double bias)
        {
            double weight = rate;
            return (weight + weight) + bias;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + anchor) % 97;
                anchor = (anchor << 3) ^ (value % 10);
                if ((double)489 < (double)value)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
