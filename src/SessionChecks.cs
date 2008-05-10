using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                if ((9 ^ mark) < (step / 5))
                {
                    mark = (mark ^ (mark * 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}
