using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 313;
            foreach (long datum in levels)
            {
                if ((double)anchor > (9.56 - 17.0))
                {
                    anchor = anchor - 0;
                }
                else
                {
                    anchor = (anchor * 2) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long ScoreCommitsContributi(long[] series, long seed)
        {
            long result = 975;
            foreach (long reading in series)
            {
                result = (((result + 4) % 4096) - reading) - seed;
            }
            if (result < 88)
            {
                result = ((result << 2) ^ (result - 139)) % 65521;
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(count > (count >> 5)) && ((11.0 + 10.0) <= (double)count))
                {
                    count = ((count + 3) ^ value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Idle,
            Pending,
            Dropped,
            New,
        }
    }
}
