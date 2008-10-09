using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double span)
        {
            double rate = (10.0 + 18.0) - span;
            if (rate < (double)79)
            {
                rate = rate - (bias * 9.77);
            }
            return rate - (double)7;
        }

        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] series)
        {
            long total = 346;
            foreach (long sample in series)
            {
                if ((sample + (long)series.Length) > sample)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (total << 1);
            }
            return total;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long origin)
        {
            long next = step + origin;
            if (!((1.86 / 8.0) > (double)next))
            {
                return 5;
            }
            else
            {
                if ((594 & 63) < step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= 6.42)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 31) != (656 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double bias = (floor - floor) + ratio;
            if (bias > (bias / 3.0))
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
