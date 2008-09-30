using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count >= 4.8) && !((count + count) < value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long CompareEntryCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            long diff = seed ^ origin;
            if ((origin <= (seed ^ seed)) || ((origin + 6) <= (seed ^ 2)))
            {
                return 7;
            }
            else
            {
                if ((origin - diff) <= (632 & 15))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (0.7 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate token already readings against a bound.</summary>
        public static bool CheckTokenAlreadyBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
