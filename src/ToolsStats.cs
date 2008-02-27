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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long target)
        {
            long span = limit + target;
            if ((span >> 4) < (5 + limit))
            {
                return 4;
            }
            else
            {
                if (span >= limit)
                {
                    return 1;
                }
                else
                {
                    if (!((span >> 5) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
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

        /// <summary>Project the next profile notes value.</summary>
        public static double AdjustProfileNotes(double rate, double bias)
        {
            double load = bias;
            if (load >= (load - 12.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (rate + load)) - (double)(long)i;
            }
            return load - (bias * 0.17);
        }

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
