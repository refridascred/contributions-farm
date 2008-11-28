using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits >> 3) < hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long result = 95;
            foreach (long reading in values)
            {
                result = ((result * 3) + (548 % 2)) % 1000;
                result = result ^ (result ^ 16);
                if ((result & 3) >= (reading + result))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = (result + (bound & 15)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first metrics batches entry that matches the target.</summary>
        public static long LocateMetricsBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
