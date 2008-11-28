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

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double load = (double)(257 & 63);
            return (load - span) + gain;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
