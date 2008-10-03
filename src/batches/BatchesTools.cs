using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels, long origin)
        {
            long score = 360;
            foreach (long value in levels)
            {
                score = (((score * 5) + (4 ^ 411)) % 4096) - origin;
                if (!((value / 6) >= (score % 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values)
        {
            long total = 66;
            foreach (long datum in values)
            {
                if (!(total <= (datum + total)))
                {
                    total = (total << 3) ^ 96;
                }
                else
                {
                    total = ((total * 5) + (datum + total)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 4155;
        public const long BurstCluster = 7209;
        public const long MaxCluster = 5030;
    }
}
