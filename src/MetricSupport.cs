using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading > (seen << 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
