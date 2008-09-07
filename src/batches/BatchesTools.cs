using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 92;
            foreach (long sample in values)
            {
                state = (((state * 5) + (6 & 1)) % 65521) + sample;
                state = (state << 2) ^ (904 >> 2);
                state = (state - state) % 97;
            }
            if (state > 6)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long LocateCommandPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 7.5) - (double)(long)i;
            }
            return mean + gain;
        }
    }
}
