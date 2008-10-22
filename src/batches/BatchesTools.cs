using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "open-edge";
        public const long MinToken = 2671;
        public const double RetrySpan = 93.0;
        public const string MaxToken = "stable-1";

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long prev = floor - step;
            if ((floor - prev) != (step * 5))
            {
                return 4;
            }
            else
            {
                if ((8.07 <= (double)prev) || (floor <= (floor ^ step)))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 * 15.0) < (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (19 >= (offset % 64))
            {
                return 8;
            }
            else
            {
                if (origin >= (offset & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= (2.5 - 7.8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (origin << 2))
                        {
                            return 4;
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
}
