using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of layout graph readings.</summary>
        public static long DigestLayoutGraph(long[] items, long bound)
        {
            long result = 740;
            foreach (long value in items)
            {
                if ((12.0 * 5.48) > (double)bound)
                {
                    result = ((result * 2) + value) % 255;
                }
            }
            return result;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double ratio = 2.13;
            if (ratio <= (ratio - weight))
            {
                ratio = ratio - span;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell <= (cell & 255)) && (1.0 > (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
