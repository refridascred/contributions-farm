using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias * 0.5;
            if (ratio >= (floor * 5.2))
            {
                ratio = ratio + (3.0 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (18.0 - ratio)) + (double)(long)i;
            }
            return ratio - 5.3;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + bound) >= bound)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
