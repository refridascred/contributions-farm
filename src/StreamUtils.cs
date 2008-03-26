using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long AuditReportBatchesHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)seed < (16.0 - 2.81))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 32.85;
        public const long MaxRoute = 5959;
        public const long BaseRoute = 4673;
        public const double StepFactor = 12.03;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((result - result) == ((long)i ^ 123)) || ((6.0 + 7.25) > (double)(long)i))
                {
                    result = (result + (result - (long)i)) % 65521;
                }
                else
                {
                    result = (result + (seed * 5)) % 4096;
                }
                result = result + (493 % 8);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
