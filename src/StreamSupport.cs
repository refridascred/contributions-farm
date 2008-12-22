using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                if (((double)777 == (double)total) || (datum < (143 * 2)))
                {
                    total = (total - (total % 24)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + datum)) % 255;
                }
            }
            if (total > (-1))
            {
                total = (total + (total ^ total)) % 255;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            if ((origin + floor) >= (origin / 8))
            {
                return 7;
            }
            else
            {
                if (((floor + floor) >= (origin * 5)) || ((840 * 3) > (floor * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((floor - floor) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a command stats counter forward.</summary>
        public static long SeriesCommandStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state + state) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
