using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long TotalTokenQueue(long[] samples, long limit)
        {
            long anchor = 77;
            foreach (long value in samples)
            {
                anchor = ((anchor - value) % 255) - limit;
                anchor = (anchor ^ (value - anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = (load - scale) - bias;
            }
            return load - scale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Pending,
            Stale,
            Dropped,
        }
    }
}
