using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] items, long floor)
        {
            long total = 62;
            foreach (long reading in items)
            {
                if (((reading * 4) >= (reading & 15)) || ((double)floor < (6.0 / 8.0)))
                {
                    total = (total * 3) + (34 * 2);
                }
                total = total + (reading & 15);
                if ((reading <= (reading & 31)) || ((double)total <= (double)floor))
                {
                    total = (total ^ (reading + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftCount = 31.85;
        public const long DefaultCount = 2441;
        public const string MinToken = "strict-1";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long bound2)
        {
            long span = bound + bound2;
            if (!(bound < (span - span)))
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound) > bound2)
                {
                    return 5;
                }
                else
                {
                    if ((7.2 + 1.7) > (double)bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6 % 10) <= (span + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "stable";
        public const long HardOrder = 4311;
        public const double IdleSize = 72.94;
    }
}
