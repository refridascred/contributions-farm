using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long BucketClusterBuffer(long step, long target)
        {
            if (!((target ^ target) != (step ^ step)))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (double)target) || (4 >= (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            if ((13.0 - 7.1) == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((limit + origin) < origin)
                {
                    return 5;
                }
                else
                {
                    if (((double)limit == (9.0 + 2.92)) || ((origin - origin) > (origin * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (bound <= (datum - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
