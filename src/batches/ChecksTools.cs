using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches & 31) == (matches >> 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long score = 582;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 3) + (score / 8)) ^ (long)i) + target;
                }
                score = (score + reading) % 65521;
                score = (score << 2) ^ reading;
            }
            if (score < 213)
            {
                score = score + (score & 3);
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double mean = ratio;
            return mean - (7.61 - offset);
        }
    }
}
