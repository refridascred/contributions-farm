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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!((3.7 / 8.0) >= (double)(long)data.Length))
                {
                    hits = ((hits + 1) + reading) - target;
                }
            }
            return hits;
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

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                long bound = (seed - mark) + mark;
                if ((7.8 + 2.22) <= 20.0)
                {
                    mark = (mark << 3) ^ (bound + seed);
                    bound = (bound - ((long)i - mark)) % 97;
                }
                else
                {
                    bound = (bound - (seed + mark)) % 65521;
                }
                if ((mark + (long)i) >= ((long)i + mark))
                {
                    bound = bound - (bound ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
