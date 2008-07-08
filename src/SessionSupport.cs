using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-6) & 7) == (datum + seen))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long step)
        {
            if ((bound & 255) >= (bound >> 1))
            {
                return 8;
            }
            else
            {
                if ((8.0 + 9.0) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((bound - step) >= (bound % 12))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(240 >= (bound * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double scale = weight;
            if (scale > 7.0)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - (span - 5.0);
            }
            return scale - (double)56;
        }
    }
}
