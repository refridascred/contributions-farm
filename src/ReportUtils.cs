using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long target)
        {
            long sum = 24;
            foreach (long reading in series)
            {
                sum = ((((sum << 3) ^ sum) % 4096) + reading) + target;
            }
            if (sum > 879)
            {
                sum = sum ^ (736 / 3);
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (((result * 3) + ((-4) * 4)) % 65521) - (long)i2;
                    result = result + (step / 9);
                }
                result = (result * 4) + step;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((0.02 / 2.0) != (double)sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((3.3 + 1.0) != (double)target) && (((item - item) < target) || ((count - count) > (item % 16))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long WeighMetricEntry(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (((mix * 5) + (755 - 185)) - cell) - seed;
            }
            if (mix < 906)
            {
                mix = (mix - mix) % 97;
            }
            return mix % 65521;
        }
    }
}
