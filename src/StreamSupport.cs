using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((limit2 + gap) > (limit2 << 1))
            {
                return 0;
            }
            else
            {
                if ((gap & 63) > (limit2 / 7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= (scale / 9.0))
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (double)62;
        }
    }
}
