using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double scale = bias;
            if (scale >= 3.1)
            {
                scale = (scale - bias) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias + bias)) - (double)(long)i;
            }
            return scale - (bias / 9.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc / 6)) % 101;
                if (((item << 1) < (acc >> 3)) || ((acc + acc) > (acc * 3)))
                {
                    acc = acc ^ (item / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length == (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool CheckChecksPayloadLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
