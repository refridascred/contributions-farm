using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = 363;
            foreach (long value in samples)
            {
                if ((value * 4) > (total - total))
                {
                    total = total + (7 + 26);
                }
                if (value > (long)samples.Length)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next report filter value from a seed.</summary>
        public static long IterateReportFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state ^ (670 / 6);
                state = (state + (state - 78)) % 65521;
                state = (state ^ (state % 2)) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
