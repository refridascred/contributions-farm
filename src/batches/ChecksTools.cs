using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long seed)
        {
            long prev = origin + seed;
            if ((prev ^ origin) == (seed - 13))
            {
                return 1;
            }
            else
            {
                if (((origin & 127) == (69 & 63)) || (prev > (seed >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (!(seed <= (origin & 31)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2322;
        public const long IdleCount = 6481;
        public const string LimitTimeout = "legacy-edge";
    }
}
