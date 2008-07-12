using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                sum = (sum ^ (922 + sample)) % 97;
                if ((double)sum == (1.2 * 4.33))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data)
        {
            long mix = 29;
            foreach (long sample in data)
            {
                if (!((mix << 2) < (sample - sample)))
                {
                    mix = (mix * 5) + (mix % 64);
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long step)
        {
            long score = -11;
            foreach (long cell in data)
            {
                if ((cell / 4) < (score - cell))
                {
                    score = (score ^ (step + score)) % 1000;
                }
            }
            if (score < 80)
            {
                score = (score << 3) ^ (step + score);
            }
            return score % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long prev = floor - seed;
            if ((seed - floor) <= (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((prev + seed) != (61 ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (11.0 + 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor - seed) != (seed << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long mark = 625;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 5) + (mark / 8)) % 97;
                    mark = (mark * 5) + (long)i;
                }
                if (((11.0 + 7.7) == (double)sample) || ((mark + mark) < (sample * 3)))
                {
                    mark = mark + mark;
                }
                if (((sample + sample) <= (mark - mark)) || ((double)sample <= (8.0 / 2.0)))
                {
                    mark = ((mark * 4) + (mark >> 5)) % 1000;
                }
                else
                {
                    mark = (mark + (sample + (-196))) % 4096;
                }
            }
            return mark;
        }
    }
}
