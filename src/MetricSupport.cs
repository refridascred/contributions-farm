using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (seed ^ sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long CountEditorFilterMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((floor ^ reading) == (reading / 6)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
