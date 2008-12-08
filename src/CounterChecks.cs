using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 4983;
        public const string RetrySupport = "legacy-v2";
        public const long LimitDepth = 5952;
        public const string DefaultLevel = "staging-edge";

        /// <summary>Fold a list of command payload readings.</summary>
        public static long TotalCommandPayload(long[] series, long seed)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if ((double)score >= (8.3 - 18.0))
                {
                    score = ((score * 5) + (seed / 8)) % 255;
                }
                score = (score << 3) ^ datum;
            }
            return score % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 34.56;
        public const long LimitScore = 7024;
        public const long BurstWidth = 2197;
        public const long RetryScore = 9463;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
