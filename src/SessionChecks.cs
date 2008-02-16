using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long offset)
        {
            long total = 456;
            foreach (long reading in values)
            {
                if ((total << 1) <= (reading << 1))
                {
                    total = (total ^ reading) % 4096;
                }
                total = total - (offset >> 2);
            }
            return total;
        }

        /// <summary>Look up the position of a farm graph sample.</summary>
        public static long FindFarmGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell - target) >= (hits ^ target)) && (((target - target) == (hits >> 5)) || ((double)target > (9.39 + 5.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
