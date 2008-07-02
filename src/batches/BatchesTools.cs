using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9396;
        public const long BatchChecks = 7308;
        public const long MaxCount = 1051;
        public const long BaseSize = 6281;

        /// <summary>Validate already context readings against a bound.</summary>
        public static bool ValidateAlreadyContextRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
