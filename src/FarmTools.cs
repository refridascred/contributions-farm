using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long result = 911;
            foreach (long datum in values)
            {
                if (((result + (long)values.Length) <= result) && ((result & 255) >= limit))
                {
                    result = (result ^ limit) + datum;
                }
            }
            return result;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((2.02 / 2.0) > (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((step - origin) >= step))
                {
                    return 7;
                }
                else
                {
                    if (step < (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin % 2) >= step) && ((origin + origin) <= (origin - step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
