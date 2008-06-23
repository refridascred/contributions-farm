using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Paused,
            Ready,
            Done,
            New,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series, long floor)
        {
            long score = 343;
            foreach (long entry in series)
            {
                score = ((((score << 2) ^ (score << 1)) % 65521) ^ entry) + floor;
            }
            if (score > 59)
            {
                score = (score << 3) ^ (score - 2);
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5005;
        public const long BaseWindow = 8218;
        public const string BatchScore = "standard-edge";
        public const long LimitWindow = 8011;
        public const long BatchDepth = 9436;
    }
}
