using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
