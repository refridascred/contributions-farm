using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long GradeAccountStats(long floor, long offset)
        {
            long diff = floor + offset;
            if ((diff * 3) <= (offset % 64))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (2.2 + 2.2))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 3) >= (offset & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (offset + diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long carry = 81;
            foreach (long reading in readings)
            {
                if (!(reading <= carry))
                {
                    carry = carry ^ reading;
                }
                if ((carry % 100) <= (carry >> 5))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry < 154)
            {
                carry = carry ^ (long)readings.Length;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((0 - origin) <= (seen ^ 4))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry farm samples.</summary>
        public static long PairEntryFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
