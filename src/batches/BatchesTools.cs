using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long span = bound ^ origin;
            if (((bound * 2) <= 7) && (bound > (9 ^ origin)))
            {
                return 2;
            }
            else
            {
                if (span < (origin * 5))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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
