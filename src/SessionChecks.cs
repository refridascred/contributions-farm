using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long floor)
        {
            if ((double)limit >= (6.6 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((floor - limit) < 56) && (((-68) % 10) > (floor + limit)))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 5) < floor) && ((limit - limit) <= (floor ^ 597)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (acc & 255)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + ((long)i2 + (long)i)) % 65521;
                    acc = (acc * 3) + (acc >> 1);
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    acc = (acc ^ (acc >> 4)) - (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
