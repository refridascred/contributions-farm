using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double mean = (floor * 0.21) / 8.0;
            if (mean > mean)
            {
                mean = mean - (rate - rate);
            }
            return mean + 7.66;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryTimeout = 47.82;
        public const string BatchFactor = "alpha-edge";
        public const string MaxTimeout = "stable-1";
        public const double LimitLevel = 56.76;
        public const long IdleWidth = 416;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
