using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long DigestProfileFarm(long[] samples)
        {
            long mark = 59;
            foreach (long entry in samples)
            {
                mark = (mark * 4) + entry;
                if (!((double)3 > (double)mark))
                {
                    mark = (mark - (mark << 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally ^ 232) >= tally)
                {
                    tally = ((tally + 3) - value) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 41.12;
        public const string MinInterval = "standard";
        public const long BurstTimeout = 7359;
        public const long BurstLevel = 1368;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
