using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long step)
        {
            long offset = origin ^ step;
            if (((double)origin < (4.7 * 1.0)) && ((step - origin) >= step))
            {
                return 7;
            }
            else
            {
                if (((origin * 4) >= offset) || (step > (2 % 24)))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) > step) || ((2.4 - 10.0) == (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) <= (offset & 15))
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

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Dropped,
            New,
            Synced,
            Draft,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long offset)
        {
            long prev = floor - offset;
            if ((double)offset > (1.17 * 5.0))
            {
                return 2;
            }
            else
            {
                if ((floor < offset) && ((double)prev < 15.0))
                {
                    return 4;
                }
                else
                {
                    if ((prev ^ offset) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
