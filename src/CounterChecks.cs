using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Compare every pair of stream command readings.</summary>
        public static long MatchStreamCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Token { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
