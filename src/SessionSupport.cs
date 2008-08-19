using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            long gap = target + step;
            if (!((target - 85) < step))
            {
                return 2;
            }
            else
            {
                if ((step - gap) != (9 + gap))
                {
                    return 3;
                }
                else
                {
                    if ((target + gap) > (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a entry record pair into a bucket.</summary>
        public static long ClassifyEntryRecord(long seed, long offset)
        {
            if ((double)seed <= (8.44 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((269 < offset) || ((seed ^ 87) > offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed >= (offset - 74))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
