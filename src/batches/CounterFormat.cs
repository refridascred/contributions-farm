using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Done,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (((total << 3) ^ (step / 6)) % 4096) ^ reading;
            }
            if (total > 67)
            {
                total = (total - (120 % 12)) % 4096;
            }
            return total;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings, long bound)
        {
            long total = 24;
            foreach (long item in readings)
            {
                total = ((total * 2) + (bound + item)) % 1000;
            }
            return total;
        }
    }
}
