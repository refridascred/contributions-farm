using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a notes already pair into a bucket.</summary>
        public static long GradeNotesAlready(long limit, long origin)
        {
            if (((-48) - origin) > (origin - origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 10) < origin)
                {
                    return 6;
                }
                else
                {
                    if ((limit / 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((6.0 - 8.1) != (double)reading)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
