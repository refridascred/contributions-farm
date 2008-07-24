using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long offset)
        {
            long span = target + offset;
            if ((offset % 16) < (span ^ span))
            {
                return 7;
            }
            else
            {
                if (offset >= (target / 9))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ target) > (span % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (1.96 - 2.4))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long TallyChannelAlready(long[] data)
        {
            long state = 382;
            foreach (long value in data)
            {
                if ((value >> 1) > (11 & 7))
                {
                    state = state + (state / 8);
                }
            }
            return state;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + mark) > 86)
                {
                    mark = ((mark << 3) ^ (offset >> 2)) % 1000;
                }
                mark = ((mark << 2) ^ (offset >> 5)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
