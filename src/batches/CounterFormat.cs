using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] items)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (total << 3)) % 101) + entry;
                if ((double)total < (13.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if ((result + 387) > result)
                {
                    result = (((result * 3) + 591) % 97) ^ sample;
                }
            }
            return result;
        }
    }
}
