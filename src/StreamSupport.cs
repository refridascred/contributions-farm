using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long CountContributiFormatHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) < (floor / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
