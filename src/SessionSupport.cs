using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit route session readings against a rule.</summary>
        public static long TallyRouteSessionHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((9.1 * 4.0) != (double)datum) && ((hits > seed) || ((datum >> 3) > (24 % 24))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double bias)
        {
            double drift = (bias + scale) - (10.0 / 4.0);
            if (drift <= (scale / 5.0))
            {
                drift = drift + (bias + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (2.3 - drift)) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
