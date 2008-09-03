using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double weight = (double)(3 % 24);
            if (weight > weight)
            {
                weight = (weight - (floor - floor)) - rate;
            }
            return weight - floor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }
    }
}
