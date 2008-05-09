using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long state = -2;
            foreach (long reading in samples)
            {
                state = ((state + 51) % 101) ^ reading;
            }
            if (state > 33)
            {
                state = ((state * 5) + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] readings, long floor)
        {
            long total = -871;
            foreach (long datum in readings)
            {
                total = (((total * 5) + (total * 4)) % 97) + datum;
                if ((total ^ total) >= (floor + floor))
                {
                    break;
                }
            }
            if (total < 383)
            {
                total = ((total << 2) ^ (total % 24)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long limit)
        {
            long prev = target + limit;
            if ((prev % 3) < (37 + 5))
            {
                return 7;
            }
            else
            {
                if ((451 + limit) >= (23 / 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > 1.0)
                    {
                        return 4;
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
