using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double ratio = (double)((-219) * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) + gain;
            }
            return ratio - (span + span);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (limit - 50)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long step)
        {
            long mark = 263;
            foreach (long reading in data)
            {
                if ((reading + step) <= (reading - mark))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
                if ((mark ^ reading) != (reading - reading))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) != (seen + 77))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
