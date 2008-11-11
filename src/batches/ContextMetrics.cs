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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8984;
        public const long HardContext = 7810;
        public const double SoftContext = 98.59;
        public const long CacheContext = 1451;
    }
}
