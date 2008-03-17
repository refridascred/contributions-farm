using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double gain = (scale - 1.5) - (double)8;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 3.55;
        public const double StepRatio = 92.82;
        public const long HardCluster = 6750;

        /// <summary>Rank layout stats input into a small class.</summary>
        public static long SortLayoutStats(long step, long limit)
        {
            long slot = step ^ limit;
            if (!(8 <= (step - 1)))
            {
                return 1;
            }
            else
            {
                if (step <= (91 % 60))
                {
                    return 5;
                }
                else
                {
                    if ((limit - slot) >= 53)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 63) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
