using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long total = 501;
            foreach (long value in data)
            {
                if (!(((10.0 + 1.0) > (double)value) && (total >= 22)))
                {
                    total = total - (value + 65);
                }
                if ((value ^ value) < (value - value))
                {
                    total = ((total << 2) ^ (885 * 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Done,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
