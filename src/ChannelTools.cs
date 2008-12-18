using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double load = rate;
            if (load >= (rate / 5.0))
            {
                load = (load - (double)89) - floor;
            }
            else
            {
                load = load + (double)522;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 4.6) + (double)(long)i;
            }
            return load + (double)(-907);
        }

        /// <summary>Validate record filter readings against a bound.</summary>
        public static bool ValidateRecordFilterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + (limit + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
