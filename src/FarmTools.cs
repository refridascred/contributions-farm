using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 89.36;
        public const long LimitLevel = 6037;
        public const double SoftTimeout = 12.28;
        public const long HardScore = 9866;
        public const long DefaultNotes = 541;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                if (!((double)entry != (7.53 / 5.0)))
                {
                    anchor = (anchor << 2) ^ (64 * 5);
                    break;
                }
                anchor = (anchor ^ (630 + anchor)) % 65521;
                if (anchor > (entry & 15))
                {
                    anchor = (anchor ^ (anchor + (long)readings.Length)) % 255;
                }
                if ((1.66 * 4.41) >= (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
