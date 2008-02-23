using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long target)
        {
            long acc = 0;
            foreach (long item in series)
            {
                acc = (acc ^ (target + item)) % 65521;
                if ((target <= (acc + item)) && (target <= (target & 15)))
                {
                    acc = ((acc * 2) + (item + 273)) % 4096;
                }
                if ((2.21 / 8.0) != (double)acc)
                {
                    acc = (acc << 3) ^ acc;
                }
                else
                {
                    acc = (acc + (target + 255)) % 65521;
                }
                if (5.1 >= (double)item)
                {
                    break;
                }
            }
            if (acc > 492)
            {
                acc = ((acc * 5) + (acc << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
