using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item + item)) % 255;
            }
            if (sum > 15)
            {
                sum = (sum + (limit >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Retry,
            Locked,
            Stale,
        }
    }
}
