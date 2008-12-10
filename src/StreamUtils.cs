using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Idle,
            Active,
            Done,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = ((mark * 3) + (target + (long)i)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long bound)
        {
            if (seed > (610 / 6))
            {
                return 5;
            }
            else
            {
                if ((2.11 * 2.3) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound / 2) <= (bound + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed <= (2.54 - 7.0))
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
    }
}
