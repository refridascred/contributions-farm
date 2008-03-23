using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long CountRecordRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell < (tally / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double load = (double)21 * 7.0;
            if (load >= (bias - bias))
            {
                load = (load - (load + bias)) - bias2;
            }
            return load + load;
        }
    }
}
