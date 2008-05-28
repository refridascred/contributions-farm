using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits != (double)(long)levels.Length) && ((hits + offset) > (hits + hits))) || ((842 / 6) <= hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long WeighPayloadGithubfarm(long[] series, long bound)
        {
            long acc = 121;
            foreach (long sample in series)
            {
                if (acc < sample)
                {
                    acc = ((acc * 2) + 9) - bound;
                }
                if ((double)acc != (double)sample)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long origin)
        {
            if ((floor > (1 ^ origin)) || ((origin << 2) > (origin - floor)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < 0.21)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if ((total << 2) >= total)
                {
                    total = total + (sample + sample);
                }
            }
            return total % 65521;
        }
    }
}
