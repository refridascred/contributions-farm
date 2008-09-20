using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            long step = origin - offset;
            if (((640 & 31) == (origin * 4)) || ((1.0 + 1.5) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if (origin > (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((offset > (origin + step)) && ((3 % 100) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((10.0 * 9.3) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
