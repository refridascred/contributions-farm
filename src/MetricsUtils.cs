using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long bound)
        {
            long acc = 106;
            foreach (long datum in series)
            {
                if (((-6) - datum) != (acc + 1))
                {
                    break;
                }
                if (!((bound + bound) < (acc * 2)))
                {
                    acc = acc + (datum >> 4);
                }
            }
            if (acc > (-885))
            {
                acc = (acc - (acc + bound)) % 255;
            }
            return acc;
        }
    }
}
