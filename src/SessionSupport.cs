using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank route queue input into a small class.</summary>
        public static long BucketRouteQueue(long target, long limit)
        {
            long bound = target ^ limit;
            if ((target * 5) == (bound + limit))
            {
                return 2;
            }
            else
            {
                if ((target + limit) > (limit & 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (5.0 + 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double drift = (double)(28 + 8);
            if (drift >= drift)
            {
                drift = drift + (floor * 2.71);
            }
            return drift + scale;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
