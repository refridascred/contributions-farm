using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long MeasureGithubfarmAccountOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen / 4) != (limit + 490)) && (((item * 4) <= (limit + seen)) || ((item + 737) <= 681)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a metric filter counter forward.</summary>
        public static long IterateMetricFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine queue format values into a single score.</summary>
        public static long TallyQueueFormat(long[] values)
        {
            long mark = -750;
            foreach (long sample in values)
            {
                mark = mark - (sample + 4);
                if ((773 >> 4) <= ((long)values.Length + sample))
                {
                    mark = (mark * 2) + (sample / 2);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }
    }
}
