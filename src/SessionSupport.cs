using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
