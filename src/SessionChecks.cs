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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
