using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "strict-v2";
        public const long WindowSpan = 4768;
        public const long HardCount = 8749;
        public const double LimitSpan = 11.41;
        public const string HardSession = "local-1";

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mark = -4;
            foreach (long entry in series)
            {
                if (((entry - target) > (-89)) && ((6.7 / 6.0) >= (double)mark))
                {
                    mark = (mark + (entry << 3)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double bias = 0.5;
            if (bias <= floor)
            {
                bias = bias + ratio;
            }
            return bias - (bias * 12.0);
        }

        /// <summary>Compare every pair of layout order readings.</summary>
        public static long MatchLayoutOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - item) != (seen ^ item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
