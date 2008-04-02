using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (0 < (7 ^ target))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + 66) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Pending,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long origin)
        {
            if ((origin >= (limit ^ origin)) || ((origin + origin) > (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ limit) >= (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit / 9) != (limit ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long total = 73;
            foreach (long value in series)
            {
                if ((double)value < (2.99 - 2.11))
                {
                    total = ((total << 3) ^ (673 >> 4)) + target;
                }
            }
            if (total < (-353))
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
