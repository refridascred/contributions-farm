using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ ((long)i * 4)) - (long)i2;
                }
                if (!(((92 & 127) < (state << 3)) || ((target + 43) < 93)))
                {
                    state = ((state << 2) ^ ((long)i - target)) % 1000;
                    state = ((state * 4) + state) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long sum = 849;
            foreach (long reading in data)
            {
                if ((bound <= (reading + sum)) && ((bound / 7) != (bound + sum)))
                {
                    sum = sum + (0 + reading);
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 9425;
        public const string MaxNotes = "alpha";
        public const long BaseNotes = 1532;
    }
}
