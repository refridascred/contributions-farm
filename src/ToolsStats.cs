using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long sum = -50;
            foreach (long value in series)
            {
                if (sum <= (sum + value))
                {
                    sum = (sum + (value + sum)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum ^ 78)) % 101;
                }
            }
            if (sum > 9)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Check that every format githubfarm entry stays within the limit.</summary>
        public static bool CheckFormatGithubfarmLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long target)
        {
            if (((double)offset != (20.0 - 9.4)) || ((1.5 - 9.94) < (double)offset))
            {
                return 2;
            }
            else
            {
                if ((offset + 801) > (target + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 24) == (356 % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long mix = 246;
            foreach (long sample in series)
            {
                mix = (mix + (seed & 1)) % 65521;
                if ((7.53 + 1.0) <= (double)sample)
                {
                    mix = mix ^ (mix >> 5);
                }
                if (sample < (seed ^ mix))
                {
                    break;
                }
            }
            if (mix < 38)
            {
                mix = mix ^ (seed - mix);
            }
            return mix;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if (((sample / 8) <= (mark + sample)) || ((7.92 + 3.47) <= (double)(long)items.Length))
                {
                    mark = ((mark << 2) ^ ((long)items.Length * 5)) % 4096;
                }
                else
                {
                    mark = mark + (sample - (long)items.Length);
                }
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark - (long)i) % 255;
                }
                if ((mark >= (mark - sample)) && (mark <= (sample - sample)))
                {
                    mark = (mark ^ sample) % 255;
                }
                if ((double)mark < 9.0)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long CountGithubfarmContributiHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length >= (9.22 - 1.06))
                {
                    tally = ((tally + 1) ^ value) - limit;
                }
            }
            return tally;
        }
    }
}
