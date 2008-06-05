using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound == (5.55 + 5.0))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long mix = 97;
            foreach (long item in levels)
            {
                if (((double)mix <= (8.0 + 7.35)) || ((double)mix > 10.0))
                {
                    mix = ((mix << 3) ^ seed) % 4096;
                }
                if (seed >= (item + 26))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = carry ^ (offset % 97);
                if ((10.0 / 8.0) < (double)offset)
                {
                    carry = (carry << 2) ^ (item + (long)levels.Length);
                }
                else
                {
                    carry = (carry ^ (item ^ (long)levels.Length)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (origin <= (625 * 4))
            {
                return 2;
            }
            else
            {
                if (((86 ^ floor) < (floor * 3)) && ((floor - floor) != (floor >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > (origin + origin)) || ((double)origin > (6.0 * 3.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((20.0 + 6.2) >= (double)value)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
