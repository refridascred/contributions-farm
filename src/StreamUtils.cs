using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((datum + seen) > (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long bound)
        {
            long acc = 98;
            foreach (long value in series)
            {
                acc = ((acc + bound) % 65521) ^ value;
            }
            return acc % 4096;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((gap ^ 6) > (seed & 3))
            {
                return 4;
            }
            else
            {
                if (!((bound + bound) <= bound))
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) <= (bound >> 1)) || ((gap + gap) > seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + seed) > (bound % 8))
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (19 - 8))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
