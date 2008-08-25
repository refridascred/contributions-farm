using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank filter stream input into a small class.</summary>
        public static long RankFilterStream(long step, long bound)
        {
            long bound2 = step ^ bound;
            if (68 >= bound)
            {
                return 1;
            }
            else
            {
                if ((double)65 <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((1.8 / 7.0) >= (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine farm githubfarm values into a single score.</summary>
        public static long FoldFarmGithubfarm(long[] series, long bound)
        {
            long mark = 65;
            foreach (long reading in series)
            {
                if (8.7 > (double)reading)
                {
                    mark = (((mark << 3) ^ reading) % 97) - bound;
                }
                else
                {
                    mark = (mark ^ (long)series.Length) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long target)
        {
            long next = origin + target;
            if (68 <= (target >> 2))
            {
                return 1;
            }
            else
            {
                if ((origin & 255) > (next + 60))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream session series from a seed.</summary>
        public static long DeriveStreamSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 2) ^ (floor >> 5)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
