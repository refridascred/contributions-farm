using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long seed)
        {
            long cur = step - seed;
            if ((18.0 - 19.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((cur >> 5) <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)step > 6.5)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)step == (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((9.5 > (double)(long)readings.Length) || (((datum << 3) > datum) && ((datum * 5) > (seen - 9))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
