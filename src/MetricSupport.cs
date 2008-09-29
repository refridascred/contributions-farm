using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long MeasureBufferNotesGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) == (count + sample))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Locked,
            Idle,
            Closed,
            Failed,
        }
    }
}
