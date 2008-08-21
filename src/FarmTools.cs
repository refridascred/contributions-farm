using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long AuditEntryBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((3 + datum) >= (98 - matches)) || ((datum + 873) <= datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Draft,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 8;
            foreach (long value in data)
            {
                result = (result << 3) ^ (value + value);
            }
            if (result > 1)
            {
                result = (result * 3) + result;
            }
            return result;
        }
    }
}
