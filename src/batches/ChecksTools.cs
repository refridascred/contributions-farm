using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepBudget = 52.63;
        public const long BurstCount = 8338;
        public const long SoftSize = 4052;
        public const double DefaultLayout = 73.64;
        public const long DefaultInterval = 5029;

        /// <summary>Define order limits and defaults.</summary>
        public const double StepCount = 56.85;
        public const long SoftOrder = 9881;
        public const double CacheWidth = 22.69;
        public const long HardScore = 984;
        public const string StepWidth = "alpha-v2";
    }
}
