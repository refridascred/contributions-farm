using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long IterateClusterStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((score + 4) == (9 % 64))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ offset) % 255;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long step)
        {
            long span = origin ^ step;
            if (origin > (step << 2))
            {
                return 4;
            }
            else
            {
                if ((step > (span - 43)) && ((step ^ span) >= (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((552 % 5) != (step + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span > (span - (-373)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((origin & 127) == (item >> 4)) && ((item + item) >= origin)) && ((double)origin != (double)4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)origin >= (double)seen) || ((value + value) <= (value << 2))) && (origin > (origin & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cache githubfarm readings against a rule.</summary>
        public static long TallyCacheGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (743 > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
