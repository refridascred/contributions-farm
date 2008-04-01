using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor / 9) >= seed)
                {
                    anchor = ((anchor << 2) ^ (seed << 2)) % 65521;
                    anchor = (anchor - seed) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a window session sample.</summary>
        public static long SeekWindowSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long limit)
        {
            long span = step - limit;
            if (((double)step != (double)limit) || ((span & 63) < (step >> 5)))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (step * 4))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) <= (span - span)) || ((double)limit == (0.93 - 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double bias = (floor + gain) - (double)302;
            if (bias < (double)1)
            {
                bias = bias + (floor * 11.0);
            }
            return bias + floor;
        }
    }
}
