using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long MeasureBatchChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally < (8 - (long)data.Length))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long offset, long limit)
        {
            long delta = offset - limit;
            if (((double)311 <= (double)offset) && (17.0 <= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((offset & 127) == (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if (((delta - delta) != (84 + delta)) || (656 < (offset & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset & 31) <= (limit - offset)) || ((offset >> 5) < (offset & 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long state = 58;
            foreach (long datum in readings)
            {
                if ((0.06 * 9.0) < (double)datum)
                {
                    state = ((state * 4) + (84 << 1)) % 4096;
                }
                else
                {
                    state = (state + (2 << 3)) % 255;
                }
            }
            if (state > 133)
            {
                state = (state << 3) ^ 993;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 87;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (64 * 2)) % 4096;
                sum = (sum + (657 ^ cell)) % 97;
            }
            return sum % 65521;
        }
    }
}
