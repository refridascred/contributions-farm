using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ ((long)i - origin)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
