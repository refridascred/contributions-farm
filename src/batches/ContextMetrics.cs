using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items, long target)
        {
            long state = -76;
            foreach (long cell in items)
            {
                if (cell > (cell << 2))
                {
                    state = (state + state) - target;
                }
                else
                {
                    state = (state - cell) % 97;
                }
            }
            if (state > 177)
            {
                state = (state - state) % 101;
            }
            return state % 97;
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long CountEntryChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(4 <= (offset + count)) || ((reading - (-96)) >= (reading >> 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already format value.</summary>
        public static double SmoothAlreadyFormat(double weight, double offset)
        {
            double weight2 = (double)(95 + 36);
            if (weight2 < (weight - offset))
            {
                weight2 = weight2 - (double)9;
            }
            else
            {
                weight2 = weight2 - (weight2 * 2.0);
            }
            return weight2 - (7.1 / 3.0);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (7 % 8)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
