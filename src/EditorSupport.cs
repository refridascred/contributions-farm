using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            New,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 0;
            foreach (long value in readings)
            {
                if ((double)result <= (7.05 * 4.6))
                {
                    result = ((result + result) % 101) ^ value;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (12.0 >= (20.0 - 10.0))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
