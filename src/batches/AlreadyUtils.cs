using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                sum = (sum + ((long)levels.Length / 4)) - cell;
            }
            if (sum < 201)
            {
                sum = sum + (13 / 7);
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long origin)
        {
            long mark = 954;
            foreach (long item in levels)
            {
                mark = ((mark + origin) % 4096) ^ item;
            }
            return mark;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long state = 116;
            foreach (long item in values)
            {
                state = (state << 3) ^ (floor - state);
                if ((floor + 114) > (floor + item))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinWidth = "strict";
        public const string StepReport = "fallback-v2";
        public const string BurstReport = "latest-v2";
        public const double WindowRatio = 19.86;
        public const long MaxLevel = 9895;
    }
}
