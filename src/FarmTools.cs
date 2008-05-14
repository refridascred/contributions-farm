using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Ready,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
