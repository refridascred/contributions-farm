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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long sum = 133;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 2) + (long)i) - item;
                }
                if (!((881 + sum) <= (sum % 60)))
                {
                    sum = sum - step;
                    continue;
                }
                else
                {
                    sum = (sum - (81 >> 2)) % 65521;
                }
                if ((9.3 + 8.25) == (double)step)
                {
                    sum = sum + (step & 7);
                }
            }
            return sum;
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
