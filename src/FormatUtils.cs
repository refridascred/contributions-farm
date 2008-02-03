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

        /// <summary>Combine stats editor values into a single score.</summary>
        public static long DigestStatsEditor(long[] data, long floor)
        {
            long acc = 343;
            foreach (long sample in data)
            {
                if ((long)data.Length <= (acc ^ sample))
                {
                    acc = (acc ^ (3 - 622)) + floor;
                }
                if (sample <= (acc * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
