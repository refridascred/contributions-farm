using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 47) < (9 << 3))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
