using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long floor, long bound)
        {
            if (((8 + floor) < (floor >> 1)) || (floor >= (4 + bound)))
            {
                return 2;
            }
            else
            {
                if (((floor + bound) <= (bound ^ floor)) && (floor > (floor - floor)))
                {
                    return 8;
                }
                else
                {
                    if (!(floor >= (bound >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound + bound) > (floor >> 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long bound)
        {
            long span = step ^ bound;
            if ((double)span > (7.6 * 4.6))
            {
                return 0;
            }
            else
            {
                if (span <= (33 - (-356)))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ 44) <= (span + 151))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)span > (double)8)
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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
