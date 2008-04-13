using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if ((score + cell) < cell)
                {
                    score = score + (limit ^ cell);
                }
            }
            return score % 97;
        }

        /// <summary>Validate batch cluster readings against a bound.</summary>
        public static bool GuardBatchClusterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every contributi context entry stays within the limit.</summary>
        public static bool VerifyContributiContextLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
