using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 52;
            foreach (long entry in series)
            {
                if ((6.4 + 3.29) != (double)result)
                {
                    result = ((result - 8) % 255) ^ entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
