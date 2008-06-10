using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double gain = (double)(14 * 3);
            if (gain < (gain * 5.91))
            {
                gain = (gain + (double)4) + span;
            }
            else
            {
                gain = gain - (double)26;
            }
            return gain + weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3234;
        public const long IdleInterval = 3905;
        public const long IdleCluster = 2792;
        public const long WindowCluster = 1046;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((3 + hits) >= hits) && ((sample + (long)levels.Length) < sample))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (bound + 8)) % 1000) ^ (long)i2;
                    acc = (acc + 93) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
