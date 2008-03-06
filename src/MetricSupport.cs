using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (mark >= ((-406) ^ value))
                {
                    mark = mark + (mark ^ value);
                }
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "cached";
        public const string BurstWidth = "strict-edge";
        public const long LimitRoute = 8481;
        public const long MinRoute = 4650;
    }
}
