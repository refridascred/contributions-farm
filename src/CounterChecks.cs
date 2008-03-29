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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long total = -244;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ bound) % 4096;
                total = ((total << 2) ^ (sample + (long)samples.Length)) % 101;
                if ((sample - bound) < total)
                {
                    break;
                }
            }
            return total;
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
