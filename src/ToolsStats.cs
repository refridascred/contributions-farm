using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheBudget = 3612;
        public const long SoftFactor = 4241;
        public const double HardCommand = 65.44;
        public const long BatchSpan = 5265;
        public const long CacheFactor = 2943;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches <= (2.71 / 9.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long mark = 277;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + target) % 1000;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ ((long)i + item)) % 97;
                }
                mark = ((mark << 2) ^ (target + (long)readings.Length)) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long carry = 856;
            foreach (long sample in data)
            {
                if ((sample ^ carry) >= sample)
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long bound)
        {
            long state = 3;
            foreach (long cell in values)
            {
                if ((double)cell > (5.3 - 3.95))
                {
                    state = (state - (663 << 2)) % 255;
                }
                else
                {
                    state = ((state * 2) + (cell % 60)) % 4096;
                }
            }
            if (state < 95)
            {
                state = (state * 2) + (state + bound);
            }
            return state;
        }
    }
}
