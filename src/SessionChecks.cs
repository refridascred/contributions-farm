using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                if (((acc / 9) >= (acc - entry)) || (acc <= (acc + acc)))
                {
                    acc = ((acc * 5) + (acc + acc)) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + ((long)data.Length ^ 220)) % 4096;
                }
            }
            if (acc < 4)
            {
                acc = acc + acc;
            }
            return acc % 1000;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - matches) < (cell << 3))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 50.19;
        public const string MinSpan = "local-1";
        public const double DefaultCache = 66.97;
        public const double CacheWidth = 88.65;
        public const long BaseLevel = 7869;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
