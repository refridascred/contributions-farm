using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
