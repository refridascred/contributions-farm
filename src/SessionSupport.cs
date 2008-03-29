using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long seed)
        {
            if (offset <= (54 - seed))
            {
                return 8;
            }
            else
            {
                if ((seed < (offset + offset)) && ((seed + offset) != (7 - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 38) >= (seed / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed << 3) > seed)
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

        /// <summary>Accumulate already commits samples.</summary>
        public static long WeighAlreadyCommits(long[] series)
        {
            long anchor = 60;
            foreach (long reading in series)
            {
                if (7 <= (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ reading) % 97;
                }
                anchor = (anchor << 3) ^ (anchor % 64);
            }
            if (anchor < 46)
            {
                anchor = anchor + anchor;
            }
            return anchor % 4096;
        }
    }
}
