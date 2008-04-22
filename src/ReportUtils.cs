using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)bound >= (5.84 - 5.8)) && ((bound - item) < (tally + tally))) || (tally < (tally & 31)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long mix = 63;
            foreach (long reading in samples)
            {
                mix = mix ^ (reading ^ reading);
            }
            if (mix < (-2))
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long delta = target - limit;
            if ((8.3 / 7.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit / 6) > (delta / 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
