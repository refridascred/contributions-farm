using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (4.0 <= (double)mark)
                {
                    mark = (mark << 3) ^ (mark / 5);
                }
                else
                {
                    mark = ((mark * 5) + (46 ^ mark)) % 4096;
                }
                if (((mark + sample) == (sample + 99)) && (seed > (sample * 5)))
                {
                    break;
                }
            }
            if (mark < 865)
            {
                mark = (mark + (mark % 24)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Iterate the support schema series from a seed.</summary>
        public static long SeriesSupportSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target <= 60))
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum ^ (sum + sum)) + (long)i2;
                    sum = (sum * 3) + (sum - sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin < (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long target)
        {
            long anchor = 30;
            foreach (long cell in data)
            {
                if (target < (86 >> 2))
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
                if (8.9 > (double)cell)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
