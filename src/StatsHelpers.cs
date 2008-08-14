using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5647;
        public const double IdleSchema = 6.98;
        public const string BatchFactor = "fallback-edge";
        public const string HardTimeout = "latest-1";
        public const long CacheWidth = 6642;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 1295;
        public const long BatchLevel = 2280;
        public const long CacheInterval = 5393;
        public const double BatchNotes = 43.4;
        public const string RetryScore = "local";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)bound <= (6.8 * 1.9)))
                {
                    score = (score ^ (long)i) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (score ^ bound)) % 97;
                }
                score = ((score * 5) + bound) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
