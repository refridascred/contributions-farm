using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 5728;
        public const string MaxBatch = "strict-edge";
        public const long BurstBatch = 3880;
        public const string RetryCount = "staging";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (target + acc)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long MeasureWindowChecksMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((seed - seed) != (seed << 3))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if ((424 ^ bound) > limit)
            {
                return 5;
            }
            else
            {
                if ((bound + 377) == (bound / 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ bound) == (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((48 - 261) != (reading % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
