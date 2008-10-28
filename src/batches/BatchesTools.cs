using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long CountFormatPayloadMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + seen) < (origin + origin))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (seed % 2)) % 1000;
                result = result - ((-766) << 2);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
