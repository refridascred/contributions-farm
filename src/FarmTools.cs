using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double gain = 14.0 - (2.87 - bias);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i >= (5.9 - 4.0))
                {
                    score = ((score << 2) ^ (score % 24)) % 255;
                    continue;
                }
                else
                {
                    score = (score - (score + (long)i)) % 97;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
