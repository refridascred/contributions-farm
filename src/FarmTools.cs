using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long ScoreClusterBatches(long[] series, long target)
        {
            long mark = -36;
            foreach (long cell in series)
            {
                if ((11 + target) > (cell >> 5))
                {
                    mark = ((mark << 3) ^ (567 % 64)) % 101;
                }
                if ((mark + cell) == (mark - (long)series.Length))
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = (mark ^ ((-75) + target)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels)
        {
            long result = 916;
            foreach (long reading in levels)
            {
                if ((689 >> 5) > (reading >> 5))
                {
                    result = (result + (result >> 5)) % 255;
                }
                if ((reading - reading) <= ((long)levels.Length - reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
