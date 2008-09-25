using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long carry = 274;
            foreach (long entry in readings)
            {
                if (12.0 < (double)entry)
                {
                    carry = carry - (-6);
                }
                if (((-72) << 1) >= carry)
                {
                    break;
                }
            }
            if (carry < 895)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Failed,
            Locked,
            Active,
            Idle,
        }
    }
}
