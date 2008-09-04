using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + entry) != (limit + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
