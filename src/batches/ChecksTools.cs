using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long AuditChannelBatchHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((191 >= (hits >> 5)) || (sample >= (7 << 3)))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batches farm readings against a bound.</summary>
        public static bool VerifyBatchesFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout notes entries that pass the check.</summary>
        public static long TallyLayoutNotesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)229 == (double)matches)
                {
                    matches = ((matches + 2) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
