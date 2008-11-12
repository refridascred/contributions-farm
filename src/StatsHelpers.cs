using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double mean = (weight * 3.1) * 7.95;
            if (mean <= weight)
            {
                mean = (mean + mean) - bias;
            }
            else
            {
                mean = mean + weight;
            }
            return mean + 6.0;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long limit)
        {
            long offset = step ^ limit;
            if ((limit + limit) > (offset + limit))
            {
                return 7;
            }
            else
            {
                if (offset < (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.85 * 6.0) == (double)offset) && (offset <= (offset + 802)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + offset) < (limit & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double floor)
        {
            double drift = (double)(256 & 31);
            if (drift > floor)
            {
                drift = drift + (drift + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)30) - (double)(long)i;
            }
            return drift - weight;
        }
    }
}
