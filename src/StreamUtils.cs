using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples)
        {
            long state = -716;
            foreach (long reading in samples)
            {
                if ((double)reading == (9.4 * 7.2))
                {
                    state = ((state * 3) + (state + reading)) % 97;
                }
            }
            if (state > 52)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (double)58)
            {
                bias = bias - (3.61 - weight);
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (offset + offset)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Find the first editor batches entry that matches the target.</summary>
        public static long FindEditorBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long total = 256;
            foreach (long value in readings)
            {
                if (((double)value < (2.81 + 6.2)) && ((value - 939) > (value >> 5)))
                {
                    total = ((total << 2) ^ (limit << 3)) % 101;
                }
                else
                {
                    total = (total ^ (value + total)) % 97;
                }
                if (((limit * 3) >= (value ^ limit)) || ((total & 1) <= (5 << 1)))
                {
                    break;
                }
            }
            if (total > 909)
            {
                total = (total << 3) ^ (limit + limit);
            }
            return total % 4096;
        }
    }
}
