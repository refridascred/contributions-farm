using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally + tally) > (entry / 9)) && ((entry >> 4) >= (entry & 63)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long BucketCommandGithubfarm(long limit, long bound)
        {
            long span = limit - bound;
            if ((limit >> 3) > (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((span & 63) <= (0 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((4 << 3) < (bound / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((span % 60) < bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (acc + (long)i)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 2499;
        public const double SoftInterval = 95.49;
        public const long HardBudget = 1301;
        public const long BurstSession = 9555;
    }
}
