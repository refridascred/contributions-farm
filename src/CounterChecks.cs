using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSize = 709;
        public const long StepRatio = 8170;
        public const long SoftFactor = 8883;
        public const long MinChannel = 4502;
        public const string SoftTimeout = "primary-edge";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                if ((state < (state >> 2)) && ((5.04 + 6.0) != (double)state))
                {
                    state = (((state * 4) + (state % 8)) % 65521) ^ datum;
                }
                if ((state - 11) < (state / 9))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 2) + (state + 347)) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 861;
            foreach (long value in readings)
            {
                if (755 < (811 ^ mix))
                {
                    mix = ((mix + (mix * 4)) % 255) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the command commits entries that pass the check.</summary>
        public static long CountCommandCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - seen) != (reading << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
