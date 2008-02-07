using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools batch entries that pass the check.</summary>
        public static long TallyToolsBatchOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((step < (tally + step)) || ((2.8 - 1.6) <= (double)step))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if (cell < (cell - cell))
                {
                    acc = ((acc * 2) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc + (acc ^ cell);
                }
            }
            if (acc < (-59))
            {
                acc = ((acc << 2) ^ 336) % 255;
            }
            return acc;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Locked,
            Active,
            Retry,
        }
    }
}
