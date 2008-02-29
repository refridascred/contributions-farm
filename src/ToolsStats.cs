using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long StepQueueFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit & 3) != (1 * 5))
                {
                    score = score + (long)i;
                }
                if (score < (score / 2))
                {
                    score = ((score * 5) + (score / 4)) % 255;
                }
                if ((2.0 * 8.84) >= (double)(long)i)
                {
                    break;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 3) + (long)i) % 97;
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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long bound)
        {
            if ((step - bound) < (step + step))
            {
                return 2;
            }
            else
            {
                if ((bound << 3) != (step & 3))
                {
                    return 4;
                }
                else
                {
                    if ((step % 64) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - bound) >= 57)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long WeighAlreadyQueue(long[] items)
        {
            long result = 65;
            foreach (long item in items)
            {
                if ((result + item) <= (item >> 2))
                {
                    result = (result << 2) ^ (item % 5);
                }
            }
            if (result > 83)
            {
                result = result + (result % 24);
            }
            return result;
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
