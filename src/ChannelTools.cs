using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a schema route reading.</summary>
        public static double ScaleSchemaRoute(double weight, double bias)
        {
            double mean = 19.0;
            if (mean >= (mean + 4.95))
            {
                mean = (mean + (mean / 4.0)) + weight;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long offset)
        {
            long score = 59;
            foreach (long cell in items)
            {
                score = (score + (score * 2)) % 1000;
                if (!((offset << 1) == (cell << 1)))
                {
                    score = score + (6 + offset);
                }
                if ((cell >> 5) > (cell + (-38)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
