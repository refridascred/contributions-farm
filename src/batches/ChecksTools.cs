using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(bound < matches))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long floor)
        {
            long carry = 85;
            foreach (long entry in series)
            {
                if (571 <= (carry / 9))
                {
                    carry = (((carry << 2) ^ (entry + 968)) % 65521) + floor;
                }
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Stale,
            Draft,
            Idle,
            Done,
        }
    }
}
