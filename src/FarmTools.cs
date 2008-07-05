using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double rate = (double)(132 ^ 2);
            if (rate < (rate / 9.0))
            {
                rate = rate - 7.3;
            }
            return rate - (bias + offset);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (19 > (item - 778))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema layout input into a small class.</summary>
        public static long BucketSchemaLayout(long floor, long step)
        {
            if ((floor >> 1) > (floor + step))
            {
                return 2;
            }
            else
            {
                if ((step / 8) >= step)
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
