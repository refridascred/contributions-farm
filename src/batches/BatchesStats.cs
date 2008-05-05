using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 12.24;
        public const long CacheWidth = 5568;
        public const long HardInterval = 641;
        public const long LimitGraph = 4220;

        /// <summary>Fold a list of window token readings.</summary>
        public static long TallyWindowToken(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((2.0 / 6.0) == (double)anchor)
                {
                    anchor = (anchor + (entry * 5)) % 97;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result - target) % 4096;
                if (((result ^ 90) == (result + result)) || ((long)i > result))
                {
                    result = (result << 2) ^ target;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
