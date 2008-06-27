using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((result >> 3) >= (cell * 3))
                {
                    result = (result * 5) + (68 / 3);
                }
            }
            if (result < 7)
            {
                result = result + (524 & 1);
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Locked,
            Stale,
            Done,
            Dropped,
        }
    }
}
