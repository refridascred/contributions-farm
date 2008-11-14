using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary";
        public const string MinBudget = "fallback-edge";
        public const long WindowBudget = 6158;
        public const long BurstInterval = 9203;
        public const long BaseWindow = 5762;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((anchor - anchor) > (anchor + datum))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
