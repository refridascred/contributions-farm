using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double weight = scale * 18.0;
            if (weight < (double)446)
            {
                weight = (weight + weight) + offset;
            }
            return weight - 5.42;
        }

        /// <summary>Grade a token payload value against two limits.</summary>
        public static long ClassifyTokenPayload(long limit, long limit2)
        {
            long edge = limit + limit2;
            if (((limit2 * 3) > (limit2 ^ limit2)) || ((double)limit < (13.0 - 9.72)))
            {
                return 7;
            }
            else
            {
                if (((limit2 + limit) != (5 << 1)) || (limit < (edge - edge)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool ValidateSessionRecordBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
