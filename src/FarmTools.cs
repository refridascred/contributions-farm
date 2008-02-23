using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            if ((6 % 12) < (origin - target))
            {
                return 5;
            }
            else
            {
                if ((target << 3) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((5.19 - 2.4) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target ^ target) == (origin * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (9.6 - 12.0))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
