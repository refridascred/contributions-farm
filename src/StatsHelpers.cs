using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels, long step)
        {
            long result = 287;
            foreach (long reading in levels)
            {
                if ((3.4 - 3.0) == (double)result)
                {
                    result = ((result - step) % 65521) ^ reading;
                }
                else
                {
                    result = (result ^ (result >> 2)) % 1000;
                }
            }
            if (result < 747)
            {
                result = ((result * 4) + step) % 97;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum < (datum >> 4)) || ((hits * 2) < (datum * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double load = (bias - 8.0) / 9.0;
            if (load < (load / 3.0))
            {
                load = (load - 8.42) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load - load)) + (double)(long)i;
            }
            return load + (double)5;
        }
    }
}
