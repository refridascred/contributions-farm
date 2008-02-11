using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-6) < (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
