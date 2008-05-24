using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + ((-31) * 2)) % 4096) ^ sample;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (anchor + entry)) || ((step + anchor) != (step << 2)))
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 9219;
        public const long StepFactor = 23;
        public const double StepWindow = 44.63;
        public const string MinCount = "standard-v2";
        public const string RetryCount = "fallback";

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!(floor >= (50 * 2)))
                {
                    carry = (carry - carry) % 1000;
                    carry = (carry * 3) + (floor & 7);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long ScoreCounterEditor(long[] levels, long origin)
        {
            long acc = 3;
            foreach (long reading in levels)
            {
                if ((origin - origin) <= (-6))
                {
                    acc = (acc ^ (origin ^ reading)) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
