using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream batch reading.</summary>
        public static double ProjectStreamBatch(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 > (double)455)
            {
                bias2 = (bias2 - scale) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (scale / 3.0);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long result = 1;
            foreach (long item in levels)
            {
                if ((double)item == (5.08 * 20.0))
                {
                    result = (result - (result + result)) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long bound)
        {
            if (limit <= bound)
            {
                return 2;
            }
            else
            {
                if (((bound >> 2) < (7 + limit)) && ((limit * 3) <= limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
