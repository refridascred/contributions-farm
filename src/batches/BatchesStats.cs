using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleInterval = 18.4;
        public const long BurstNotes = 1503;
        public const double IdleNotes = 48.31;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long target)
        {
            if ((floor - target) >= (target & 31))
            {
                return 3;
            }
            else
            {
                if (target > (90 % 16))
                {
                    return 7;
                }
                else
                {
                    if (((0.3 / 4.0) > (double)target) && ((double)target == (4.1 * 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - floor) < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((10.0 + 3.0) > (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long total = 711;
            foreach (long sample in data)
            {
                if (((double)sample > (4.72 / 6.0)) && ((sample >> 4) >= (total >> 2)))
                {
                    total = total ^ (sample << 1);
                }
                else
                {
                    total = ((total << 3) ^ (total * 2)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
