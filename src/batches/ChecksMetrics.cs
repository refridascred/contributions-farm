using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "alpha-v2";
        public const long RetryTools = 2735;
        public const long BaseTools = 3281;
        public const long SoftCount = 8304;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total << 2) ^ ((long)i2 + 197)) % 101;
                }
                total = ((total * 4) + ((long)i * 4)) % 1000;
                if ((5.9 / 5.0) == (double)(long)i)
                {
                    total = ((total * 2) + 5) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long TallyStatsCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value ^ hits) != (hits ^ 55)) || ((value & 15) >= (66 << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long bound)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                if ((mix >= entry) && ((16.0 * 8.87) != (double)entry))
                {
                    mix = (mix << 3) ^ (8 ^ entry);
                    continue;
                }
                if ((mix << 1) <= 490)
                {
                    mix = (mix - (7 >> 5)) % 97;
                }
                if (((bound + bound) <= (bound + mix)) && ((double)936 <= (double)mix))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ (bound << 2)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long FoldWindowReport(long[] levels)
        {
            long mix = 131;
            foreach (long datum in levels)
            {
                if ((mix + datum) < datum)
                {
                    mix = mix + (datum - datum);
                }
            }
            if (mix > 16)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
