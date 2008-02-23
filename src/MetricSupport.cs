using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (floor <= (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor <= 6.66) && (floor <= (floor ^ offset)))
                {
                    return 6;
                }
                else
                {
                    if (((offset - offset) < (95 - floor)) || ((double)offset < (5.3 * 2.3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 - floor) != (offset ^ offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long ScoreChannelGithubfarm(long[] data, long seed)
        {
            long score = 4;
            foreach (long item in data)
            {
                if (!((item ^ item) == (seed >> 4)))
                {
                    score = score - (score >> 4);
                }
                if (score < (seed - item))
                {
                    score = score ^ item;
                }
                else
                {
                    score = (score * 3) + (score & 31);
                }
            }
            return score;
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long WeighFarmToken(long[] series, long offset)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (offset <= (offset % 100))
                {
                    mark = (mark << 2) ^ (value + offset);
                }
            }
            if (mark < 213)
            {
                mark = mark - (offset - 1);
            }
            return mark;
        }
    }
}
