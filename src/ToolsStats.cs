using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long step)
        {
            if (((0 * 5) >= target) && (target >= (target % 16)))
            {
                return 4;
            }
            else
            {
                if (!((step + 0) <= (25 / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) > (target % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target < 7)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long CompareMetricBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 3;
            foreach (long datum in levels)
            {
                if ((66 ^ 4) == (mark * 4))
                {
                    mark = (((mark << 3) ^ (target + 26)) % 1000) - datum;
                }
            }
            if (mark > 37)
            {
                mark = (mark ^ (73 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long bound)
        {
            if ((bound + target) != (target + target))
            {
                return 1;
            }
            else
            {
                if ((target + target) == (target * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
