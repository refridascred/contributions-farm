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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
