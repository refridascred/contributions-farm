using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = -3;
            foreach (long value in readings)
            {
                score = ((score * 2) + (value * 3)) % 65521;
            }
            if (score < 548)
            {
                score = (score * 4) + (score - score);
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.8 + 2.0))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
