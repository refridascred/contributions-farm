using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next channel counter value from a seed.</summary>
        public static long SeriesChannelCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.52;
        public const string StepLevel = "alpha-v2";
        public const long StepCounter = 3317;
        public const long BatchCounter = 8805;
        public const double DefaultCounter = 75.88;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((bound % 10) != (bound + hits))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
