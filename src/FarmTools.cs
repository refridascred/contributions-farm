using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long AuditQueueFormatHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) == (64 - (long)data.Length))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
