using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((span + 68) <= (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset) < offset2)
                {
                    return 3;
                }
                else
                {
                    if ((span + offset2) <= (span - offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset2 * 5) < (offset2 + (-32))) && ((span ^ offset2) != (95 - span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((578 - seen) == (seen - seen)) && ((22 < (330 - seen)) || ((reading + reading) < (seen + (long)items.Length))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Pending,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading > seed) && ((tally % 100) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((6.2 / 4.0) <= (double)span))
            {
                return 0;
            }
            else
            {
                if (((7 + limit) <= limit) || ((limit - 1) > (floor + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)954)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
