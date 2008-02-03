using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ tally) == (411 - target))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (limit <= (edge % 8))
            {
                return 6;
            }
            else
            {
                if (!((edge % 64) >= (limit % 8)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) < (limit / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + limit) < edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
