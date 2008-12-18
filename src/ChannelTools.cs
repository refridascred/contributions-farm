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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Queued,
            Active,
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
