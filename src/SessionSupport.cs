using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= (total ^ total)) && ((double)target >= 18.0))
                {
                    total = ((total * 3) + (9 & 7)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
