using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue commits input into a small class.</summary>
        public static long BucketQueueCommits(long limit, long floor)
        {
            if ((limit & 31) <= (769 - floor))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 6) != ((-883) + 437))
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

        /// <summary>Find the first batch stats entry that matches the target.</summary>
        public static long FindBatchStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed - mark) > mark)
                {
                    long seen = (seed - seed) + (seed ^ seed);
                    mark = mark + (seen ^ seed);
                }
                else
                {
                    mark = mark - (mark + mark);
                }
                if (!((double)mark <= (double)seed))
                {
                    mark = (mark ^ (mark - seed)) % 1000;
                    mark = (mark << 3) ^ seed;
                }
                if ((((-27) + (long)i) <= (seed + (long)i)) || ((double)mark > (double)(long)i))
                {
                    mark = mark - seed;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long floor)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if (((acc + acc) <= floor) && ((item % 16) == ((long)series.Length / 2)))
                {
                    long edge = 73;
                    acc = ((acc << 3) ^ (edge >> 5)) % 101;
                }
                if ((3.39 + 4.43) < (double)acc)
                {
                    acc = (acc + (floor / 5)) % 97;
                    break;
                }
                if ((4 % 64) == (floor / 9))
                {
                    acc = acc + (acc ^ floor);
                }
            }
            return acc;
        }
    }
}
