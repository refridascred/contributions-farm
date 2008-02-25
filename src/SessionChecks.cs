using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                if ((floor + item) == (1 + 85))
                {
                    anchor = ((anchor * 4) + (item - floor)) % 1000;
                    continue;
                }
                anchor = (anchor - (2 - item)) % 255;
            }
            return anchor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
