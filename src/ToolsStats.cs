using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + matches) < matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support commits samples are out of range.</summary>
        public static long MeasureSupportCommitsOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((origin << 2) <= hits) && ((long)data.Length == (origin << 2)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
