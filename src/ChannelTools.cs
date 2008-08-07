using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum < (datum * 4))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 7147;
        public const long IdleFactor = 3186;
        public const string HardLevel = "alpha-v2";
        public const long WindowPayload = 7283;
        public const long LimitTimeout = 7268;

        /// <summary>Roll a graph support counter forward.</summary>
        public static long SeriesGraphSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
