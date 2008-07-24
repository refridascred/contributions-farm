using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if ((limit <= (4 << 1)) || ((limit + 48) < (limit % 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) != (11 >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((3 + limit) >= (903 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((-701) << 2) <= (datum + datum))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((15.0 / 9.0) < (double)(long)data.Length)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
