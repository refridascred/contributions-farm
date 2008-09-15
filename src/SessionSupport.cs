using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double scale2 = scale + (9.0 - scale);
            return scale2 + (bias + scale);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count % 5) < count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff > (bound + bound)) && ((bound & 63) <= (bound - origin)))
            {
                return 3;
            }
            else
            {
                if ((diff + diff) >= (5 + origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) <= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (4.0 - 18.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
