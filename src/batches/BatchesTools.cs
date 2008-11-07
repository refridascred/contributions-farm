using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record format entry stays within the limit.</summary>
        public static bool GuardRecordFormatRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window metrics entries.</summary>
        public static long TallyWindowMetrics(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ (entry << 2)) % 1000;
                if ((state + entry) < (43 + state))
                {
                    state = (state - (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
