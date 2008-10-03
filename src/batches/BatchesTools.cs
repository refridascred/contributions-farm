using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
