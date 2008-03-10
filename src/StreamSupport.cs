using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) > seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long WeighGithubfarmContext(long[] items)
        {
            long anchor = 4;
            foreach (long value in items)
            {
                if ((value + 2) >= anchor)
                {
                    anchor = (anchor + (anchor & 31)) % 97;
                }
                else
                {
                    anchor = (anchor ^ ((-351) + anchor)) % 255;
                }
                if ((double)anchor < (3.0 - 7.97))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
