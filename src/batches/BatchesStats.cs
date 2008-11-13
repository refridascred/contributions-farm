using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 1182;
        public const long StepStats = 3728;
        public const string BatchStats = "local-v2";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double bias = span;
            return bias + (bias + scale);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < 3.0)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
