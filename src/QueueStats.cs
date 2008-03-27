using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data)
        {
            long acc = 70;
            foreach (long sample in data)
            {
                if ((double)acc < (double)533)
                {
                    acc = (acc - (acc >> 1)) - sample;
                }
                else
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Rank report tools input into a small class.</summary>
        public static long ClassifyReportTools(long limit, long step)
        {
            if (!((double)step <= (6.2 * 7.09)))
            {
                return 8;
            }
            else
            {
                if (((step + limit) >= (limit % 8)) && ((step + step) < (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ limit) > (step * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long floor)
        {
            long result = -1;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((-80) + result))
                {
                    result = (result * 5) + (result - floor);
                }
                else
                {
                    result = (result + (floor - floor)) % 101;
                }
            }
            return result;
        }
    }
}
