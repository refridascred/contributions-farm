using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((floor >> 2) != (floor * 3)) && (((count - count) <= (floor * 4)) && ((item * 3) != ((long)items.Length + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8066;
        public const long IdleBudget = 9428;
        public const long WindowOrder = 8363;
        public const long StepOrder = 3102;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double mean = (double)(887 & 3);
            if (mean >= (mean / 8.0))
            {
                mean = mean - (mean + floor);
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + 6.9;
        }
    }
}
