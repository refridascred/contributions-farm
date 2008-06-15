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

        /// <summary>Look up the position of a contributi tools sample.</summary>
        public static long SeekContributiToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
