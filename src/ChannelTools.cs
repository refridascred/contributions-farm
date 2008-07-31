using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support command values into a single score.</summary>
        public static long TotalSupportCommand(long[] readings, long floor)
        {
            long score = 31;
            foreach (long cell in readings)
            {
                if (698 > (975 + floor))
                {
                    score = (score - (cell + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepSpan = 18.71;
        public const long MaxAccount = 1751;
        public const long BaseSize = 2751;
    }
}
