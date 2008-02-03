using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long offset)
        {
            if (!((seed & 15) != (seed + offset)))
            {
                return 1;
            }
            else
            {
                if ((double)offset < (1.6 / 2.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
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

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long offset)
        {
            long span = target ^ offset;
            if (((target & 3) > (offset ^ 15)) || ((target >> 1) > (span >> 1)))
            {
                return 3;
            }
            else
            {
                if ((6 << 1) == (target + offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
