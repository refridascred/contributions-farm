using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) > 3) && ((offset / 7) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate > 12.0)
            {
                rate = (rate - ratio) + bias;
            }
            else
            {
                rate = rate - (rate * 7.67);
            }
            return rate - ratio;
        }
    }
}
