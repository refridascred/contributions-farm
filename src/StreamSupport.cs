using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double ratio = 1.8;
            if (ratio < bias)
            {
                ratio = (ratio - (ratio + bias)) - scale;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSize = 70.45;
        public const long SoftLayout = 4473;
        public const long IdleLayout = 786;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
