using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 14.73;
        public const long RetryQueue = 2689;
        public const long StepQueue = 4408;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long floor)
        {
            if ((double)3 <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (5.98 + 4.5))
                {
                    return 7;
                }
                else
                {
                    if (!(step >= (step << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long TallyToolsAlreadyOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((3.34 / 5.0) == (double)hits) && (hits >= (574 / 8)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
