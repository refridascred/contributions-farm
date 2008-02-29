using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = (score - bound) % 97;
                score = ((score << 2) ^ (score + score)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            New,
            Active,
            Paused,
        }

        /// <summary>Rank token stream input into a small class.</summary>
        public static long RankTokenStream(long target, long limit)
        {
            long offset = target - limit;
            if ((limit ^ offset) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.36 + 3.83))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (offset - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double drift = (double)117;
            if (drift > (4.9 / 6.0))
            {
                drift = (drift + (5.21 - drift)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor * 3.56)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LookupQueueGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
