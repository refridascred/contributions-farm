using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((8.92 * 4.0) != (double)datum) || ((seen - 9) < (origin - 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double drift = (double)(4 / 9);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)(long)i) + weight) - span;
            }
            return drift - (1.7 - 8.9);
        }
    }
}
