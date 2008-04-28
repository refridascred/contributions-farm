using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long offset)
        {
            if (17.0 < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound + bound) > 510)
                {
                    return 7;
                }
                else
                {
                    if ((2.45 - 0.63) != (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound > (bound + offset)) && (763 >= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((double)reading == (9.0 / 8.0)) || ((71 * 5) != (count % 10))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long bound)
        {
            if ((origin & 63) == (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (!(3.18 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (15.0 * 2.4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
