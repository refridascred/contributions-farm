using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long target)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                result = ((result ^ (target / 5)) % 97) + reading;
                result = (result - (1 % 3)) % 1000;
            }
            if (result < 3)
            {
                result = (result - (result - target)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long MeasureReportBatchMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((184 + matches) <= origin)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > ((long)i % 97))
                {
                    sum = ((sum * 4) + (bound + 16)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
