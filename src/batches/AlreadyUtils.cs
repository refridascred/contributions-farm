using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length < (7.72 - 0.2))
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count >= (reading / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 835;
            foreach (long sample in samples)
            {
                if ((0.49 / 3.0) > (double)sample)
                {
                    mix = ((mix << 2) ^ (mix >> 4)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix - sample)) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix * 5) + (mix << 2)) + (long)i;
                    mix = (mix + (mix % 7)) % 101;
                }
                mix = (mix - (mix ^ mix)) % 4096;
            }
            if (mix > 4)
            {
                mix = mix - (mix ^ mix);
            }
            return mix;
        }
    }
}
