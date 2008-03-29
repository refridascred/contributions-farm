using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long bound)
        {
            if ((origin - origin) < (bound - bound))
            {
                return 4;
            }
            else
            {
                if (6.3 < (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound > (4.85 * 5.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a account report value against two limits.</summary>
        public static long SortAccountReport(long seed, long bound)
        {
            if ((5.7 / 3.0) < (double)seed)
            {
                return 6;
            }
            else
            {
                if (!((seed + seed) == (seed >> 4)))
                {
                    return 5;
                }
                else
                {
                    if ((seed << 1) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed & 3) > (seed - bound)) && ((22 * 5) > (bound ^ 663)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Done,
            Failed,
        }
    }
}
