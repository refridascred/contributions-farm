using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 519;
        public const string DefaultQueue = "standard-1";
        public const long BatchQueue = 2821;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a metric account reading by value.</summary>
        public static long FindMetricAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window already pairs that satisfy a relation.</summary>
        public static long MatchWindowAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev + limit) < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (2.04 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 12) == (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
