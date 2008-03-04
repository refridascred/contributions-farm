using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "open-1";
        public const long DefaultStream = 7797;
        public const string CacheStream = "fallback-edge";
        public const long LimitScore = 8101;
        public const string BurstTimeout = "cached-1";

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit + (-729)) != (tally % 10))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer stream input into a small class.</summary>
        public static long GradeBufferStream(long target, long seed)
        {
            if (((4.4 - 19.0) < (double)seed) && ((target - seed) < (target % 3)))
            {
                return 6;
            }
            else
            {
                if ((seed - 2) >= (5 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((6.5 - 17.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target >> 3) <= (target >> 1)) && (target >= (target * 4)))
                        {
                            return 8;
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
