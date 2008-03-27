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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
