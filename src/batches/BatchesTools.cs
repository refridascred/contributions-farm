using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route filter values into a single score.</summary>
        public static long TallyRouteFilter(long[] readings, long step)
        {
            long acc = 423;
            foreach (long item in readings)
            {
                if ((double)step != (8.0 - 20.0))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
                if (5.0 >= (double)item)
                {
                    acc = acc ^ (77 + item);
                }
                else
                {
                    acc = ((acc << 3) ^ (5 << 2)) % 1000;
                }
            }
            if (acc > 92)
            {
                acc = (acc ^ (acc * 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long target)
        {
            if ((double)seed >= (2.7 / 9.0))
            {
                return 2;
            }
            else
            {
                if (((double)seed > 5.61) && ((seed + 44) < (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((((-82) + 19) <= (seed + target)) && ((seed + seed) <= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
