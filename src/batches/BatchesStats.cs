using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window record readings against a bound.</summary>
        public static bool GuardWindowRecordRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long carry = 83;
            foreach (long entry in series)
            {
                if ((carry - entry) < (long)series.Length)
                {
                    carry = ((carry << 2) ^ (carry * 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double weight, double floor)
        {
            double mean = weight;
            return mean - floor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (8 < (cur / 3))
            {
                return 2;
            }
            else
            {
                if ((double)cur >= (5.64 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
