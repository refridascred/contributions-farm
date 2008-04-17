using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 921;
            foreach (long value in readings)
            {
                if ((anchor >> 5) > (anchor << 1))
                {
                    anchor = anchor ^ (anchor - value);
                }
                else
                {
                    anchor = anchor ^ (96 ^ (long)readings.Length);
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor - (8 + 68)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
