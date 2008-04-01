using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (15.0 - 7.0)) || (bound < (score * 5)))
                {
                    score = score + (bound % 7);
                    score = ((score << 3) ^ (score % 12)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double drift = (rate * 3.49) + (floor / 8.0);
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
