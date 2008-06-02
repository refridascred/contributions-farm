using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (tally + 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool CheckGithubfarmPayloadBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double gain = scale;
            return (gain + (gain + scale)) + bias;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
