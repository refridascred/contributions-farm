using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + entry) != (entry & 3)) && ((5.0 / 2.0) >= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if ((value + value) != (acc - value))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 922)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Find the first contributi support entry that matches the target.</summary>
        public static long FindContributiSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
