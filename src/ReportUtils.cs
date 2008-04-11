using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long bound)
        {
            long delta = step ^ bound;
            if (!((double)step <= (double)delta))
            {
                return 7;
            }
            else
            {
                if ((53 * 3) < (step & 127))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor - 3) < (total * 2)))
                {
                    total = (total ^ (total - floor)) % 65521;
                    total = (total + (-950)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            New,
            Closed,
            Draft,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            New,
            Stale,
            Active,
        }

        /// <summary>Find the first buffer payload entry that matches the target.</summary>
        public static long LocateBufferPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
