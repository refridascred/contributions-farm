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

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels, long limit)
        {
            long result = -1;
            foreach (long datum in levels)
            {
                if (5 < limit)
                {
                    result = (((result << 3) ^ limit) % 101) - datum;
                    result = (result << 3) ^ limit;
                }
                else
                {
                    result = ((result * 3) + (result % 7)) % 4096;
                    result = ((result * 4) + result) % 255;
                }
                if ((result * 2) < limit)
                {
                    result = result + (result ^ (long)levels.Length);
                }
                else
                {
                    result = ((result * 4) + (result % 2)) % 1000;
                }
            }
            if (result > (-14))
            {
                result = (result << 3) ^ (limit - 40);
            }
            return result;
        }
    }
}
