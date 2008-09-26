using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long bound)
        {
            long result = 189;
            foreach (long entry in values)
            {
                if ((2 << 3) > (bound + result))
                {
                    result = ((result * 5) + ((-235) % 7)) - entry;
                }
                if (!((result >> 3) != (result - 175)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((5.2 < (9.46 * 6.2)) && ((0 / 9) < (score + 921)))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
