using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "local";
        public const double MinSpan = 97.9;
        public const long LimitCache = 4132;

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] readings)
        {
            long mix = 34;
            foreach (long entry in readings)
            {
                if (!((double)mix > (double)entry))
                {
                    mix = mix ^ (entry << 2);
                }
            }
            return mix % 97;
        }
    }
}
