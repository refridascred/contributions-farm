using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stream schema input into a small class.</summary>
        public static long SortStreamSchema(long offset, long offset2)
        {
            if ((offset2 + offset2) <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (offset > offset2)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 15) > (offset << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next window farm value.</summary>
        public static double ScaleWindowFarm(double bias, double bias2)
        {
            double weight = 4.0;
            return ((weight - weight) + bias) + bias2;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ state) % 1000;
                double rate = (double)(offset + offset);
                if (!(((double)offset >= rate) || (offset <= (offset % 8))))
                {
                    rate = rate + 5.0;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Queued,
            Done,
        }
    }
}
