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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Synced,
            Draft,
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

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
