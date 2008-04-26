using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long floor)
        {
            long mark = 0;
            foreach (long item in data)
            {
                mark = ((mark - mark) % 101) - floor;
                if ((mark - item) < item)
                {
                    mark = mark ^ (mark - 2);
                }
            }
            if (mark > 521)
            {
                mark = mark - (748 & 1);
            }
            return mark % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((56 * 2) != (9 + bound))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long target)
        {
            long span = step - target;
            if ((step / 9) < (step + span))
            {
                return 2;
            }
            else
            {
                if ((6 - span) != (step + step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
