using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long bound)
        {
            if ((bound + seed) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound % 100) == (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > (seed + 248))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound & 63) <= (bound - seed)) && (seed >= (seed - bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long mark = 42;
            foreach (long reading in levels)
            {
                if ((11.0 * 15.0) == (double)mark)
                {
                    mark = (mark ^ (120 ^ floor)) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor + (target << 3)) % 1000) - sample;
                if (((target >> 4) == (long)data.Length) || (397 <= (target / 2)))
                {
                    anchor = (anchor << 2) ^ (46 << 1);
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor % 65521;
        }
    }
}
