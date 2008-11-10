using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen > (seen & 15))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long offset)
        {
            long result = 420;
            foreach (long datum in readings)
            {
                result = (result + (datum - result)) % 65521;
            }
            if (result > 87)
            {
                result = (result + offset) % 101;
            }
            return result % 97;
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
