using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batches farm pair into a bucket.</summary>
        public static long SortBatchesFarm(long target, long offset)
        {
            long edge = target ^ offset;
            if ((double)edge != (6.1 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((offset / 9) <= (298 + edge))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (6.8 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many farm route samples are out of range.</summary>
        public static long MeasureFarmRouteHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((2.0 / 5.0) != (double)origin)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double gain = offset / 5.0;
            if (gain < gain)
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)69) - (double)(long)i;
            }
            return gain + (offset - ratio);
        }
    }
}
