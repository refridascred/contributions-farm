using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((bound + step) != (bound * 5))
            {
                return 7;
            }
            else
            {
                if (((4.64 - 5.48) <= (double)bound) && ((double)bound < 3.1))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >= (entry * 2)) || (((count + entry) < 20) && ((double)entry <= (0.95 - 13.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
