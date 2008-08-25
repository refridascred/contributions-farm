using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 132;
        public const double BaseNotes = 12.99;
        public const double StepRatio = 11.85;
        public const long MaxDepth = 327;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((18.0 * 1.0) > (double)bound) && ((double)result >= 6.67))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum >= (datum - hits)) || ((hits * 2) > (hits + datum)))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster buffer measurements.</summary>
        public static double ScaleClusterBuffer(double ratio, double floor)
        {
            double scale = (double)(37 << 1);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (ratio + ratio)) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
