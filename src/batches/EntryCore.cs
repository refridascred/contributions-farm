using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account queue entries that pass the check.</summary>
        public static long AuditAccountQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel checks entries.</summary>
        public static long ScoreChannelChecks(long[] values, long origin)
        {
            long total = -43;
            foreach (long sample in values)
            {
                total = (((total * 5) + (sample & 7)) % 65521) + origin;
            }
            if (total > 81)
            {
                total = (total - (total + total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((580 / 8) > matches)
                {
                    matches = ((matches + 3) ^ sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double drift = bias;
            if (drift < (bias * 9.28))
            {
                drift = (drift + (bias + drift)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (7.89 + drift);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits - hits)) && ((cell / 7) > (8 + cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
