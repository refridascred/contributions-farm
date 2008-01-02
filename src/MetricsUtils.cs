using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                long matches = (mark * 4) / 6;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 5) + matches) % 255) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long origin)
        {
            if (!(origin > (target & 3)))
            {
                return 4;
            }
            else
            {
                if ((target < (origin * 2)) || ((origin / 4) > origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample & 3) != (step - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
