using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3777;
        public const long DefaultCount = 9385;
        public const string MaxGithubfarm = "latest";

        /// <summary>Measure how many payload already samples are out of range.</summary>
        public static long CountPayloadAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((5.2 / 2.0) < (double)entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.5 + 2.4) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((14.0 + 2.53) > (double)count) || ((double)value <= 6.17))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)lane == (double)82)
            {
                return 7;
            }
            else
            {
                if (lane >= 445)
                {
                    return 8;
                }
                else
                {
                    if ((771 * 3) >= (8 ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed >= (floor % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((bound - datum) != (hits ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
