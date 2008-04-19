using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = load - (double)(-76);
            }
            else
            {
                load = load + (gain + load);
            }
            return load - (double)6;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long origin)
        {
            if (!((floor + floor) >= (521 - origin)))
            {
                return 5;
            }
            else
            {
                if ((7.69 / 9.0) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((9.6 / 7.0) == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= 3.78)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!(entry <= (62 << 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
