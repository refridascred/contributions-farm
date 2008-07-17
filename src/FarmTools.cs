using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long cell in readings)
            {
                if ((sum > cell) || ((cell + sum) != (83 >> 2)))
                {
                    sum = (sum ^ (seed - seed)) % 255;
                }
            }
            if (sum > 3)
            {
                sum = sum + (seed << 1);
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Validate notes queue readings against a bound.</summary>
        public static bool VerifyNotesQueueLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
