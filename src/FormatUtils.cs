using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series)
        {
            long score = 898;
            foreach (long value in series)
            {
                score = ((score * 2) + (value / 3)) % 101;
                score = score - value;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 74.41;
        public const long BaseProfile = 3518;
        public const string DefaultCount = "latest-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "strict-1";
        public const double BaseFarm = 41.91;
        public const string LimitFarm = "primary";
        public const long SoftCount = 5063;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
