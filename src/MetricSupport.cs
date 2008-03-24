using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format cluster pair into a bucket.</summary>
        public static long SortFormatCluster(long step, long limit)
        {
            long cur = step - limit;
            if ((limit / 7) < (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((cur ^ limit) < (1 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ 2) < (step % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double ratio = (double)(478 & 127);
            if (ratio > (0.67 - ratio))
            {
                ratio = (ratio - (double)819) + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 6.0) + (double)(long)i;
            }
            return ratio + (span - 8.0);
        }
    }
}
