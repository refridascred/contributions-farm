using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long TallyStreamLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(233 >= (cell * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 6293;
        public const string HardSize = "local-edge";
        public const string HardBuffer = "cached";
        public const string DefaultRatio = "latest";
        public const long RetryScore = 8682;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long origin)
        {
            if ((seed - seed) < (origin << 3))
            {
                return 4;
            }
            else
            {
                if (origin > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)39 == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
