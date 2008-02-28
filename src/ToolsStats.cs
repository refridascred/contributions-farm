using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = -2;
            foreach (long item in series)
            {
                anchor = ((anchor - (826 ^ limit)) % 65521) - item;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 3) + ((-266) * 3);
            }
            return anchor;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long bound)
        {
            if (!(bound <= (floor + 7)))
            {
                return 3;
            }
            else
            {
                if (!((floor / 4) < (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if (((541 ^ floor) != (4 - floor)) || (874 <= (floor * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor >= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cluster window samples.</summary>
        public static long PairClusterWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxInterval = 47.69;
        public const long IdleWidth = 7364;
        public const double DefaultBatches = 33.54;

        /// <summary>Iterate the token contributi series from a seed.</summary>
        public static long SeriesTokenContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - score) % 101) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
