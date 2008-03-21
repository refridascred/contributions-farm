using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally * 2) < item)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report already entry stays within the limit.</summary>
        public static bool CheckReportAlreadyRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (bound < ((long)i / 5))
                {
                    state = (state + 339) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 2) ^ state) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
