using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 17.92;
        public const long WindowWidth = 4668;
        public const double SoftAlready = 87.23;

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
