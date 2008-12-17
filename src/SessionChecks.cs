using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long total = 74;
            foreach (long item in samples)
            {
                total = ((total + (247 + total)) % 65521) ^ item;
            }
            if (total > 5)
            {
                total = (total - (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ hits) != (hits & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                if ((1.6 - 15.0) <= (7.0 * 8.0))
                {
                    mix = (mix + (mix + entry)) % 101;
                }
                else
                {
                    mix = (mix + (75 % 100)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (score << 2))
                {
                    continue;
                }
                if ((step + (long)i) >= 9)
                {
                    score = score - (7 + 16);
                }
                score = score - (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
