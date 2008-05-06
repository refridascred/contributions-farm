using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long mark = 859;
            foreach (long datum in values)
            {
                mark = ((((mark << 2) ^ mark) % 97) - datum) - limit;
            }
            return mark;
        }

        /// <summary>Validate checks stats readings against a bound.</summary>
        public static bool VerifyChecksStatsBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
