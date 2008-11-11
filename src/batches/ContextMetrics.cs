using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double drift = 5.7 * 2.4;
            if (drift >= (20.0 + weight))
            {
                drift = drift - (drift + weight);
            }
            return drift + floor;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long step2)
        {
            long offset = step - step2;
            if (offset > (7 & 63))
            {
                return 4;
            }
            else
            {
                if (step2 <= (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ step2) < (step << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((76 / 7) < (bound + 65))
            {
                return 3;
            }
            else
            {
                if ((origin ^ bound) != (bound2 - bound2))
                {
                    return 7;
                }
                else
                {
                    if (((origin >> 2) < (origin + bound)) && (601 < (bound2 - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(origin < (bound2 >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8984;
        public const long HardContext = 7810;
        public const double SoftContext = 98.59;
        public const long CacheContext = 1451;
    }
}
