using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a entry cache sample.</summary>
        public static long LookupEntryCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                long next = (seed & 15) - ((long)i + seed);
                if ((double)seed < (double)(long)i)
                {
                    score = score - next;
                    score = score + (long)i;
                    break;
                }
                else
                {
                    score = score - (score / 6);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftRatio = "legacy-edge";
        public const long SoftNotes = 6736;
        public const double BaseDepth = 64.36;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits - entry) > (long)readings.Length) && ((double)floor <= (7.9 - 6.35)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
