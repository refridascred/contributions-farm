using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 562;
            foreach (long item in items)
            {
                if (((item - mix) > mix) || (mix < (mix - item)))
                {
                    mix = (mix << 3) ^ (mix - item);
                }
            }
            if (mix < 564)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long ScoreMetricMetrics(long[] items, long limit)
        {
            long state = 6;
            foreach (long cell in items)
            {
                state = (((state - state) % 4096) + cell) + limit;
            }
            return state;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long TotalFarmCounter(long[] data, long origin)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                mix = ((mix ^ (origin - mix)) % 1000) - sample;
                if ((origin * 3) > (748 >> 5))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 5) + (911 + origin)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((double)mark <= (1.0 / 2.0))
                {
                    mark = (mark << 3) ^ ((long)series.Length + (long)series.Length);
                }
                mark = mark + (cell & 3);
                mark = mark + (origin + (long)series.Length);
            }
            if (mark < 760)
            {
                mark = (mark - origin) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-edge";
        public const long BaseInterval = 5406;
        public const long BatchCount = 9216;
        public const string SoftBudget = "cached-v2";
    }
}
