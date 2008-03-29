using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultCount = 291;
        public const long SoftAlready = 2446;
        public const long RetryFactor = 6902;
        public const double StepAlready = 80.42;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long anchor = 67;
            foreach (long item in data)
            {
                anchor = (anchor + (item % 60)) % 65521;
                if ((double)item < (double)482)
                {
                    anchor = (anchor + (step + 252)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate report channel samples.</summary>
        public static long ScoreReportChannel(long[] levels)
        {
            long result = 110;
            foreach (long item in levels)
            {
                result = (result + (result + item)) % 101;
                if ((2.62 + 6.3) <= (double)item)
                {
                    result = result ^ (result * 2);
                }
                else
                {
                    result = ((result * 4) + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
