using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mix > (2.32 / 2.0)))
                {
                    mix = (mix - (long)i) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
