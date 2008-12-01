using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
