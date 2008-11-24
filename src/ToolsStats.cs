using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor - (long)i;
                if (!((anchor >> 1) > anchor))
                {
                    anchor = (anchor << 3) ^ ((long)i % 5);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((25 - floor) >= (473 + seen))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long ClassifyNotesChecks(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((limit * 3) >= delta)
            {
                return 0;
            }
            else
            {
                if ((limit & 63) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 3) < (limit - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta * 2) >= (limit2 + 20))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate window order readings against a bound.</summary>
        public static bool VerifyWindowOrderRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
