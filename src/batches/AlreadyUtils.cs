using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - anchor) < (anchor ^ (long)i))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 601;
        public const long RetryLevel = 715;
        public const long IdleTimeout = 219;
        public const long BaseSpan = 6110;

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i == (floor + mark)))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (80 - mark)) % 97;
                }
                if (((mark - 8) <= (floor & 7)) && ((floor - (long)i) <= floor))
                {
                    break;
                }
                if (floor > (long)i)
                {
                    mark = mark + (mark / 9);
                    mark = (mark << 3) ^ floor;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up token entry samples.</summary>
        public static long PairTokenEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
