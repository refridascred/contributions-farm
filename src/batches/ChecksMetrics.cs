using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long acc = 727;
            foreach (long item in data)
            {
                if (target <= (long)data.Length)
                {
                    acc = (acc ^ (item % 7)) % 101;
                    acc = acc - (item >> 3);
                }
                if ((item - target) <= (acc / 8))
                {
                    acc = acc ^ 244;
                }
                else
                {
                    acc = (acc ^ target) % 97;
                }
            }
            if (acc < (-4))
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Failed,
            Paused,
            New,
            Done,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitBudget = 8785;
        public const long MinCommand = 140;
        public const long CacheBudget = 6843;
        public const string CacheSpan = "cached-edge";
        public const double StepCommand = 39.93;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((17.0 / 8.0) != (double)datum)
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
