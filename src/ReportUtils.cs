using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long step)
        {
            if (((7.0 / 8.0) == (double)limit) && ((step + limit) > (limit << 2)))
            {
                return 8;
            }
            else
            {
                if (limit <= (step / 8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 4) + (40 & 127)) + (long)i;
                }
                result = ((result << 2) ^ cell) % 101;
                if (14.0 > (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] items)
        {
            long anchor = 30;
            foreach (long datum in items)
            {
                if ((anchor ^ datum) == (anchor - 488))
                {
                    anchor = (anchor * 3) + (anchor ^ anchor);
                    anchor = ((anchor * 4) + (datum % 24)) % 1000;
                }
                else
                {
                    anchor = anchor + (datum - 9);
                }
                if (((datum / 2) <= (anchor - datum)) || ((anchor - 4) >= 276))
                {
                    anchor = (anchor + (51 + datum)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (datum + datum);
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor * 5) + (anchor / 5);
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long sum = -319;
            foreach (long sample in readings)
            {
                if ((9.0 * 7.0) < (3.69 + 15.0))
                {
                    sum = ((sum ^ sum) % 101) + sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((state + bound) >= (long)i) && (bound >= ((-5) << 3))))
                {
                    long delta = 74 % 100;
                    state = state - ((long)i - delta);
                }
                state = (state ^ 56) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
