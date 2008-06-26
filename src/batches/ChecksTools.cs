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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (total % 3)) % 65521;
                total = (total << 2) ^ (5 + origin);
                total = total - (total - origin);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
