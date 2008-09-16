using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double gain = span - span;
            if (gain < rate)
            {
                gain = gain - (double)(-75);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool ValidateCommandSchemaLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
