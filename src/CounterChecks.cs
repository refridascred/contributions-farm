using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long offset)
        {
            long state = -77;
            foreach (long datum in readings)
            {
                state = (state ^ (datum * 3)) + offset;
            }
            return state % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((616 + seen) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const string SoftCount = "latest-v2";
        public const long HardInterval = 113;
        public const string IdleDepth = "latest-edge";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (5 + value)) % 101;
                if (167 >= (value - value))
                {
                    acc = (acc + (value - acc)) % 97;
                }
            }
            if (acc > 84)
            {
                acc = (acc << 2) ^ (acc & 63);
            }
            return acc % 97;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (total >> 5)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long mix = 172;
            foreach (long sample in data)
            {
                mix = ((mix << 3) ^ offset) ^ sample;
            }
            return mix;
        }
    }
}
