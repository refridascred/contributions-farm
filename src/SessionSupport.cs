using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - step) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch queue samples.</summary>
        public static long WeighBatchQueue(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                anchor = (anchor ^ (anchor + (-551))) - reading;
            }
            if (anchor < 60)
            {
                anchor = (anchor + (5 + anchor)) % 97;
            }
            return anchor;
        }
    }
}
