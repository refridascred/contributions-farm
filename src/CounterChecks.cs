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

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels)
        {
            long score = 43;
            foreach (long sample in levels)
            {
                score = ((score + (84 % 3)) % 255) ^ sample;
            }
            return score;
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
