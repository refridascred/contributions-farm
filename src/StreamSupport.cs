using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate queue account readings against a bound.</summary>
        public static bool CheckQueueAccountLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((75 + hits) < (step & 31))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double span)
        {
            double rate = (double)(134 + 8);
            if (rate < (rate * 6.7))
            {
                rate = ((rate - (1.89 + rate)) - bias) + span;
            }
            return rate + (rate - rate);
        }
    }
}
