using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache channel readings.</summary>
        public static long DigestCacheChannel(long[] readings)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= total)
                {
                    total = (total ^ (total * 2)) % 97;
                    break;
                }
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
