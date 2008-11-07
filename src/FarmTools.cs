using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double ratio = 7.6 - (bias + rate);
            if (ratio >= 3.5)
            {
                ratio = ratio - (3.4 - rate);
            }
            return ratio + (rate * 6.0);
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long DeriveChannelMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - (score & 7);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
