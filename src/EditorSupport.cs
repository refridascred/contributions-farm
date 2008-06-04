using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5376;
        public const string BurstContributi = "fallback";
        public const long DefaultSize = 8479;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = 92;
            foreach (long item in readings)
            {
                if (mark < (1 - mark))
                {
                    mark = (mark * 2) + (item + item);
                }
            }
            if (mark < 82)
            {
                mark = (mark - (7 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)tally)
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long state = 8;
            foreach (long value in data)
            {
                state = (state ^ 358) % 255;
                if ((state >> 5) > (56 - 90))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                else
                {
                    state = (state ^ (72 - bound)) % 255;
                }
                if ((value << 2) <= 30)
                {
                    break;
                }
            }
            if (state > 507)
            {
                state = (state * 2) + 9;
            }
            return state;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
