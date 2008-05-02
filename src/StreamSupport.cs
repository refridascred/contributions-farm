using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long offset)
        {
            long lane = bound - offset;
            if ((offset + bound) > (offset ^ lane))
            {
                return 3;
            }
            else
            {
                if ((3.0 * 6.45) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((9.5 - 8.56) < (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Locked,
            New,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > bias2)
            {
                mean = mean - (mean / 2.0);
            }
            return mean - bias;
        }
    }
}
