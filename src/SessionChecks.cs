using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate graph farm readings against a bound.</summary>
        public static bool GuardGraphFarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 4) > (10 + hits)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
