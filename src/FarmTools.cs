using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long anchor = 57;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (long)i) % 1000) + entry;
                }
                anchor = (anchor + (floor * 3)) % 255;
                if ((double)floor <= (0.1 * 16.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long limit)
        {
            long step = origin - limit;
            if ((limit >= (step + step)) || ((origin & 63) == (68 >> 3)))
            {
                return 7;
            }
            else
            {
                if (((9.0 + 12.0) >= (double)limit) && (step >= (limit / 8)))
                {
                    return 4;
                }
                else
                {
                    if (((step / 6) >= (step ^ 37)) || ((double)limit == (3.0 * 20.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit - step) < (origin % 7)) && (step > (limit << 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5914;
        public const long RetryFactor = 3609;
        public const string RetryLevel = "cached-edge";
    }
}
