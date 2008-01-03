using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits ^ hits) == ((-91) << 3)) && (831 > cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            if ((474 >> 2) == (seed - (-52)))
            {
                return 2;
            }
            else
            {
                if ((0.1 - 2.9) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (seed & 31))
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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter counter forward.</summary>
        public static long SeriesEditorCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
