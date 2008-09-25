using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((floor * 3) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster buffer entry that matches the target.</summary>
        public static long SeekClusterBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
