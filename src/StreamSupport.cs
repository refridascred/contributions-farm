using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 930;
            foreach (long value in items)
            {
                mark = (mark * 4) + (value + 668);
                if ((value << 2) < value)
                {
                    mark = (mark - (63 / 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = bias;
            if (mean < (weight - 5.8))
            {
                mean = mean - 9.6;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.38) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
