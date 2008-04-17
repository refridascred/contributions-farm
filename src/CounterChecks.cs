using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "strict";
        public const string BatchTimeout = "standard-edge";
        public const long BatchInterval = 8326;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5419;
        public const long BurstSchema = 7761;
        public const long BatchSchema = 5641;
        public const long StepInterval = 4588;

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long bound)
        {
            long acc = 37;
            foreach (long cell in series)
            {
                if ((acc - 6) < (acc & 63))
                {
                    acc = (acc * 5) + (acc >> 4);
                }
                if (((bound + acc) != (cell & 127)) || ((double)cell > (14.0 - 3.1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a entry checks counter forward.</summary>
        public static long StepEntryChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
