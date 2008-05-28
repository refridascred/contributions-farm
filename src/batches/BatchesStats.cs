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

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double weight = 0.4 * 5.6;
            if (weight <= floor)
            {
                weight = weight - (double)8;
            }
            else
            {
                weight = weight - (bias + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (bias * 1.7);
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
