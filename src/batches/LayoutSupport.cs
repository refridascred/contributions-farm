using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)target < (double)(long)i))
                {
                    long step = anchor << 2;
                    anchor = (anchor - (anchor + step)) % 4096;
                }
                anchor = ((anchor * 5) + (anchor % 64)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long offset)
        {
            long lane = floor ^ offset;
            if (((lane + floor) > floor) && (8 > (lane - floor)))
            {
                return 4;
            }
            else
            {
                if ((double)lane >= 8.5)
                {
                    return 7;
                }
                else
                {
                    if ((6.21 > (double)floor) && (lane >= (floor - lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (2 * 3))
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
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }
    }
}
