using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 2182;
        public const long HardFactor = 6265;
        public const long RetryStats = 4213;
        public const long MinCount = 8756;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long seed)
        {
            long slot = target + seed;
            if ((seed - slot) < (seed + 5))
            {
                return 2;
            }
            else
            {
                if ((682 << 2) >= (seed << 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot > 17.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double mean = ratio / 6.0;
            if (mean <= (17.0 * 7.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 6.0) + (double)(long)i;
            }
            return mean - 13.0;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
