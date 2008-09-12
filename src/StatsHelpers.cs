using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double load = (double)8 - bias;
            if (load >= (double)(-9))
            {
                load = load + (1.8 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 1.0) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Iterate the window payload series from a seed.</summary>
        public static long IterateWindowPayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (652 << 2)) % 101;
                if ((score / 8) >= (floor >> 5))
                {
                    score = (score ^ (941 + 0)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)34 / 7.0;
            if (rate2 < (double)458)
            {
                rate2 = (rate2 + (bias + rate2)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 2.0) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
