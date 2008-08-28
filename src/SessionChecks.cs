using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            if ((offset - 968) == (floor ^ offset))
            {
                return 2;
            }
            else
            {
                if ((floor % 3) <= floor)
                {
                    return 8;
                }
                else
                {
                    if (!((offset << 1) >= (9 - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < 9.9)
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

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
