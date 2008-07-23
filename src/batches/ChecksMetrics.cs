using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 3) <= 1)
                {
                    result = (result << 3) ^ (entry >> 4);
                }
                if ((entry + result) >= entry)
                {
                    result = (result - (result & 3)) % 255;
                }
                else
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long state = -473;
            foreach (long reading in series)
            {
                state = (state - (reading >> 5)) % 255;
                state = (state << 3) ^ reading;
            }
            if (state > 515)
            {
                state = (state ^ (489 >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Rank schema command input into a small class.</summary>
        public static long SortSchemaCommand(long seed, long target)
        {
            if ((4.9 / 9.0) > (double)target)
            {
                return 4;
            }
            else
            {
                if (5.7 >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((target + seed) <= (seed & 255)) || ((seed + seed) == (target / 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items)
        {
            long acc = 820;
            foreach (long cell in items)
            {
                if (((double)cell > (16.0 - 4.0)) || ((acc + 1) == (acc ^ acc)))
                {
                    acc = (acc - (acc - 124)) % 65521;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ (long)items.Length;
            }
            return acc % 4096;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry < (85 + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
