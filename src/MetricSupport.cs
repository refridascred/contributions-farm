using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long origin)
        {
            if (!((146 << 1) != (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (limit > (origin ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((180 / 4) != (origin >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - origin) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 3203;
        public const long RetryStream = 8465;
        public const double BatchStream = 45.52;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
