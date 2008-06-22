using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool ValidateCommitsBufferRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long CountClusterGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 2) >= (value % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long span = offset - target;
            if ((offset << 2) > (48 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((span - target) < 967)
                {
                    return 1;
                }
                else
                {
                    if ((7.3 * 18.0) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
