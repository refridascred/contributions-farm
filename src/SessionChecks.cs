using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a commits tools value against two limits.</summary>
        public static long GradeCommitsTools(long offset, long origin)
        {
            if ((origin + origin) < (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((85 % 8) >= origin)
                {
                    return 6;
                }
                else
                {
                    if (!((origin + 16) != (offset + (-733))))
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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 157;
            foreach (long sample in data)
            {
                if (seed < anchor)
                {
                    anchor = ((anchor ^ (689 + seed)) % 97) - sample;
                }
                else
                {
                    anchor = (anchor ^ (seed / 9)) % 65521;
                }
            }
            if (anchor > 871)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor % 65521;
        }
    }
}
