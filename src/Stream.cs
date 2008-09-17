using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count graph batch pairs that satisfy a relation.</summary>
        public static long MatchGraphBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitTimeout = "fallback";
        public const long MaxWindow = 4373;
        public const double CacheWindow = 7.59;
        public const string LimitWindow = "fallback-edge";
        public const long WindowInterval = 4372;

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 11.0;
            if (gain >= (rate * 8.9))
            {
                gain = gain - rate;
            }
            return gain + (span + span);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((1.8 / 8.0) <= (double)seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
