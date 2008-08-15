using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Retry,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long CombineReportBatch(long[] series)
        {
            long total = 58;
            foreach (long cell in series)
            {
                total = ((total << 3) ^ cell) % 255;
            }
            return total;
        }
    }
}
