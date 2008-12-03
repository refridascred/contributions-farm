using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double scale2 = (scale - scale) / 9.0;
            if (scale2 >= (scale + scale2))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((49 + target) == (datum + target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            New,
            Done,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
