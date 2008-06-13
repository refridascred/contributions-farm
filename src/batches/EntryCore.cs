using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowBudget = 4143;
        public const long WindowProfile = 5758;
        public const long BurstProfile = 994;
        public const string MinProfile = "alpha-1";

        /// <summary>Blend two metrics account measurements.</summary>
        public static double AdjustMetricsAccount(double bias, double span)
        {
            double scale = (double)(8 % 100);
            if (scale < (double)3)
            {
                scale = scale - (1.4 - bias);
            }
            return scale - (span - 13.0);
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long TallyPayloadRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen + step) < step) && ((seen + entry) < step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes support entries that pass the check.</summary>
        public static long TallyNotesSupportMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((903 + sample) < (sample / 4))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
