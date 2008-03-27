using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a schema checks figure with a bias.</summary>
        public static double ProjectSchemaChecks(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias2) - (double)(long)i) - bias;
            }
            return scale - (double)609;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long acc = 703;
            foreach (long sample in levels)
            {
                acc = (acc - (0 & 31)) % 1000;
                acc = (acc << 3) ^ (limit & 31);
                if ((double)acc == (19.0 * 0.13))
                {
                    acc = (acc * 4) + (sample + (-760));
                }
                else
                {
                    acc = acc + (acc * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8.0 + 7.71) <= (double)matches) && ((value * 3) <= matches))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
