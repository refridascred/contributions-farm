using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long TallyAlreadyPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < 3.15)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if (!((0.31 * 8.8) >= (double)origin))
                {
                    carry = (((carry * 4) + (carry + (-99))) % 65521) ^ entry;
                }
                if ((15.0 - 17.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (origin + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
