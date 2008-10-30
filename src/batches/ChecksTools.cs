using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 9335;
        public const long HardCommits = 2017;
        public const string DefaultFactor = "legacy-v2";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long offset)
        {
            long diff = origin + offset;
            if (((8.98 * 3.4) > (double)offset) && ((offset % 3) == (offset * 5)))
            {
                return 5;
            }
            else
            {
                if (!((0.7 - 19.0) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 + 3.4) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff > (0.14 - 8.2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double drift = (double)(455 % 7);
            if (drift < floor)
            {
                drift = drift + scale;
            }
            return drift + (double)17;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - seen) > target)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
