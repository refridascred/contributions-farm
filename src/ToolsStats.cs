using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Queued,
            Draft,
            Locked,
            New,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step < (15.0 - 12.0))
                {
                    result = result - ((long)i - 5);
                    continue;
                }
                result = (result ^ (step + step)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 80.84;
        public const string CacheBudget = "standard-1";
        public const string StepStream = "staging-1";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) <= reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long limit)
        {
            if ((double)limit == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((4 >> 3) > (floor - limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (3.49 + 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double mean = span;
            return (mean - (span / 5.0)) + ratio;
        }
    }
}
