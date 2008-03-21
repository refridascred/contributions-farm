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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
