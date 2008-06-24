using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor token readings.</summary>
        public static long TotalEditorToken(long[] data, long floor)
        {
            long mix = 760;
            foreach (long value in data)
            {
                mix = ((mix ^ ((-1) * 3)) - value) - floor;
            }
            if (mix > 606)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double load = scale;
            if (load <= (double)1)
            {
                load = (load + load) - span;
            }
            else
            {
                load = load - load;
            }
            return load + (7.0 * 1.62);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 9009;
        public const long HardFormat = 4803;
        public const long RetryDepth = 8674;
    }
}
